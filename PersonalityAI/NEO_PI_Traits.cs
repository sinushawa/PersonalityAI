using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityAI
{
    public enum NEO_PI_Domain
    {
        Neuroticism,
        Extraversion,
        Openness,
        Agreeableness,
        Conscientiousness
    }
    public struct Trait_stats
    {
        public float min;
        public float max;
        public float mean;
        public float delta;
    }
    class TraitAttr: Attribute
    {
        internal TraitAttr(double mass, double radius)
        {
            this.Mass = mass;
            this.Radius = radius;
        }
        public double Mass { get; private set; }
        public double Radius { get; private set; }
    }

    public enum NEO_PI_Traits
    {
        Anxiety,
        Hostility,
        Depression,
        Consciousness,
        Impulsiveness,
        Vulnerability,
        Warmth,
        Gregariousness,
        Assertiveness,
        Activity,
        Excitement,
        Positive,
        Fantasy,
        Aesthetics,
        Feelings,
        Actions,
        Ideas,
        Values,
        Trust,
        Straightforwardness,
        Altruism,
        Compliance,
        Modesty,
        Tender,
        Competence,
        Order,
        Dutifulness,
        Achievement,
        Discipline,
        Deliberation
    }
}
