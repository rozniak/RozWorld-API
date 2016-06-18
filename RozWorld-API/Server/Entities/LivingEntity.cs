/**
 * Oddmatics.RozWorld.API.Server.Entities.ILivingEntity -- RozWorld Living Entity
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Server.Event;
using Oddmatics.RozWorld.API.Server.Game;
using System;

namespace Oddmatics.RozWorld.API.Server.Entities
{
    /// <summary>
    /// Represents a living entity in a world.
    /// </summary>
    public abstract class LivingEntity : Entity
    {
        /// <summary>
        /// Gets or sets the health of this LivingEntity.
        /// </summary>
        public int Health
        {
            get { return _Health; }
            private set
            {
                if (HealthChanged != null)
                    HealthChanged(this, value);

                _Health = value;
            }
        }
        private int _Health;

        /// <summary>
        /// Gets whether this LivingEntity is alive.
        /// </summary>
        public bool IsAlive { get { return Health == 0; } }

        /// <summary>
        /// Gets whether this LivingEntity is freezable.
        /// </summary>
        public abstract bool IsFreezable { get; }

        /// <summary>
        /// Gets or sets whether this LivingEntity is frozen.
        /// </summary>
        public bool IsFrozen
        {
            get { return _IsFrozen; }
            set { _IsFrozen = IsFreezable && value; }
        }
        private bool _IsFrozen;

        /// <summary>
        /// Gets whether this LivingEntity is poisoned.
        /// </summary>
        public bool IsPoisoned { get { return false; } } // TODO: This

        /// <summary>
        /// Gets whether this LivingEntity is stunned.
        /// </summary>
        public bool IsStunned { get { return false; } } // TODO: This

        /// <summary>
        /// Gets the SafeStatHandler for this LivingEntity 
        /// </summary>
        public SafeStatHandler Stats { get; protected set; }


        /// <summary>
        /// Occurs when this LivingEntity takes damage.
        /// </summary>
        event HealthCauseEventHandler DamageTaken;

        /// <summary>
        /// Occurs when this LivingEntity dies.
        /// </summary>
        event EntityDeathEventHandler Died;

        /// <summary>
        /// Occurs when this LivingEntity is healed.
        /// </summary>
        event HealthCauseEventHandler Healed;

        /// <summary>
        /// Occurs when this LivingEntity's health changes.
        /// </summary>
        event HealthChangedEventHandler HealthChanged;


        /// <summary>
        /// Deals damage to this LivingEntity.
        /// </summary>
        /// <param name="amount">The amount to damage.</param>
        /// <param name="cause">The cause of this damage.</param>
        public void DealDamage(int amount, object cause = null)
        {
            if (!IsAlive)
                throw new InvalidOperationException("Cannot damage LivingEntity, it is dead.");

            if (amount < 1)
                throw new ArgumentException("Amount of damage must be a positive value.");

            if (amount >= Health)
                Kill(cause);
            else
            {
                Health -= (int)amount;

                if (DamageTaken != null)
                    DamageTaken(this, cause, _Health, amount);
            }
        }


        /// <summary>
        /// Heals this LivingEntity.
        /// </summary>
        /// <param name="cause">The cause of this healing.</param>
        public void Heal(object cause = null)
        {
            Heal(Stats.MaxHealth - _Health, cause);
        }

        /// <summary>
        /// Heals this LivingEntity by a given amount.
        /// </summary>
        /// <param name="amount">The amount to heal.</param>
        /// <param name="cause">The cause of this healing.</param>
        public void Heal(int amount, object cause = null)
        {
            if (!IsAlive)
                throw new InvalidOperationException("Cannot heal LivingEntity, it is dead.");

            if (amount < 1)
                throw new ArgumentException("Amount to heal must be a positive value.");

            if (amount > Stats.MaxHealth)
                amount = Stats.MaxHealth - _Health;

            Health += amount;

            if (Healed != null)
                Healed(this, cause, _Health, amount);
        }

        /// <summary>
        /// Kills this LivingEntity.
        /// </summary>
        public void Kill(object cause = null)
        {
            if (!IsAlive)
                throw new InvalidOperationException("Cannot kill LivingEntity, it is dead.");

            Health = 0;

            if (Died != null)
                Died(this, cause);
        }

        /// <summary>
        /// [DIRECT INHERITORS ONLY -- ATTACH THIS TO IRWSERVER.TICK EVENT IN YOUR CONSTRUCTOR OR INCLUDE IN UPDATE METHOD]
        /// Performs updates for status effects and damaging floors etc.
        /// </summary>
        protected void LivingEntityUpdate()
        {
            // TODO: Code this
        }
    }
}
