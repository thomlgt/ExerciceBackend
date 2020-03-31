using System;
using System.Runtime.Serialization;

namespace App.Exceptions
{
    [Serializable]
    internal class RessourceException : Exception
    {
        public int Statut { get; set; }

        public RessourceException(int statut, string message) : base(message)
        {
            this.Statut = statut;
        }

    }
}