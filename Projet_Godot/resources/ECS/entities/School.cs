using Godot.Collections;
using T3.helpers;
using T3.resources.ECS.components;

namespace T3.resources.ECS.entities
{
    /**
     * <summary>School gameobject</summary>
     */
    public class School : BuildingBase
    {
        /**
         * <summary>Get the name</summary>
         */
        protected override string GetName()
        {
            return "Ecole";
        }

        /**
         * <summary>Get the dictionary of there</summary>
         */
        public override Dictionary<BuildingStats.Stats, double> ManageStats()
        {
            if (!this.TryGetComponent<BuildingHealth>(out var health)) return null;
            if (health.State.Equals(BuildingHealth.BuildingState.Old))
                return new Dictionary<BuildingStats.Stats, double>
                {
                    {BuildingStats.Stats.SatisfactionJ, -9},
                    {BuildingStats.Stats.SatisfactionA, -3},
                    {BuildingStats.Stats.SatisfactionV, 0},
                    {BuildingStats.Stats.Pollution, -4},
                    {BuildingStats.Stats.Proprete, -3},
                    {BuildingStats.Stats.QualiteDeVie, -2},
                    {BuildingStats.Stats.Sante, -1},
                    {BuildingStats.Stats.Satisfaction, -4},
                    {BuildingStats.Stats.Score, -2.8 * BuildingSize.ToInt(GetSize())}
                };

            if (health.State.Equals(BuildingHealth.BuildingState.New))
                return new Dictionary<BuildingStats.Stats, double>
                {
                    {BuildingStats.Stats.SatisfactionJ, 9},
                    {BuildingStats.Stats.SatisfactionA, 3},
                    {BuildingStats.Stats.SatisfactionV, 0},
                    {BuildingStats.Stats.Pollution, -2},
                    {BuildingStats.Stats.Proprete, 3},
                    {BuildingStats.Stats.QualiteDeVie, 3},
                    {BuildingStats.Stats.Sante, 1},
                    {BuildingStats.Stats.Satisfaction, 4},
                    {BuildingStats.Stats.Score, 1.8 * BuildingSize.ToInt(GetSize())}
                };

            return new Dictionary<BuildingStats.Stats, double>
            {
                {BuildingStats.Stats.SatisfactionJ, 0},
                {BuildingStats.Stats.SatisfactionA, 0},
                {BuildingStats.Stats.SatisfactionV, 0},
                {BuildingStats.Stats.Pollution, 0},
                {BuildingStats.Stats.Proprete, 0},
                {BuildingStats.Stats.QualiteDeVie, 0},
                {BuildingStats.Stats.Sante, 0},
                {BuildingStats.Stats.Satisfaction, 0},
                {BuildingStats.Stats.Score, 0}
            };
        }

        /**
         * <summary>Get the description</summary>
         */
        protected override string GetDescription()
        {
            return "";
        }
    }
}