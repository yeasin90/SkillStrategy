using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    //http://www.dofactory.com/net/adapter-design-pattern
    public class Client
    {
        private readonly ITarget _adapter;// = new Adapter();
        public int X { get; set; }
        public int Y { get; set; }

        public Client()
        {
            _adapter = new Adapter();
        }

        public int DisplaySum(int x, int y)
        {
            return _adapter.GetData(this);
        }
    }

    /// <summary>
    /// Target
    /// </summary>
    public interface ITarget
    {
        int GetData(Client data);
    }

    /// <summary>
    /// Adapter
    /// </summary>
    public class Adapter : ITarget
    {
        public readonly ScoreCalculation _scoreCalculation;

        public Adapter()
        {
            _scoreCalculation = new ScoreCalculation();
        }

        public int GetData(Client data)
        {
            return _scoreCalculation.Caluclate(data.X, data.Y);
        }
    }

    /// <summary>
    /// Adaptee
    /// </summary>
    public class ScoreCalculation
    {
        public int Caluclate(int x, int y)
        {
            return x + y;
        }
    }
}
