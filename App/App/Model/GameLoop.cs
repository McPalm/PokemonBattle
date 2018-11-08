using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class GameLoop
    {
        public Trainer Trainer1 { get; set; }
        public Trainer Trainer2 { get; set; }

        /// <summary>
        /// Check if the trainers are ready with their inputs, if they are, run a turn. Fire off events.
        /// </summary>
        public void Update() => throw new NotImplementedException();

        /// <summary>
        /// Logs everything that happens
        /// </summary>
        public Action<string> OnLog { get; set; }
        /// <summary>
        /// Invoked when combat is over with the losing trainer
        /// </summary>
        public Action<Trainer> OnDefeat { get; set; }
        /// <summary>
        /// invoked when the fight is over with the winning trainer
        /// </summary>
        public Action<Trainer> OnVictory { get; set; }
        /// <summary>
        /// invoked at the end of a turn if there is a new turn
        /// </summary>
        public Action OnNewTurn { get; set; }
        
    }
}
