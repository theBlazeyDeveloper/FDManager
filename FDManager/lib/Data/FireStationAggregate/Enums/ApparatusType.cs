namespace Data.FireStationAggregate
{
    public enum ApparatusType
    {
        Engine,
        Ladder,
        Tower,
        Cascade,
        Ambulance,
        Medic,
        Squad,
        AmbulanceSupervisor,
        DistrictChief,
        EMSDistrictChief,
        SafetyOfficer,
        CommandVan,
        HazMatUnit,
        TechnicalRescue,
        Unknown
    }

    public static class ApparatusTypeEnumExtensions
    {
        public static ApparatusType ToEnum(this string value)
        {
            return value switch
            {
                "Engine" => ApparatusType.Engine,
                "Ladder" => ApparatusType.Ladder,
                "Tower" => ApparatusType.Tower,
                "Cascade" => ApparatusType.Cascade,
                "Ambulance" => ApparatusType.Ambulance,
                "Medic" => ApparatusType.Medic,
                "Squad" => ApparatusType.Squad,
                "Ambulance Supervisor" => ApparatusType.AmbulanceSupervisor,
                "District Chief" => ApparatusType.DistrictChief,
                "EMS District Chief" => ApparatusType.EMSDistrictChief,
                "Safety Officer" => ApparatusType.SafetyOfficer,
                "Command Van" => ApparatusType.CommandVan,
                "Specialized Hazardous Material Unit" => ApparatusType.HazMatUnit,
                "Technical Rescue" => ApparatusType.TechnicalRescue,
                _ => ApparatusType.Unknown,
            };
        }
        public static string ToString(this ApparatusType type)
        {
            return type switch
            {
                ApparatusType.Engine => "Engine",
                ApparatusType.Ladder => "Ladder",
                ApparatusType.Tower => "Tower",
                ApparatusType.Cascade => "Cascade",
                ApparatusType.Ambulance => "Ambulance",
                ApparatusType.Medic => "Medic",
                ApparatusType.Squad => "Squad",
                ApparatusType.AmbulanceSupervisor => "Ambulance Supervisor",
                ApparatusType.DistrictChief => "District Chief",
                ApparatusType.EMSDistrictChief => "EMS District Chief",
                ApparatusType.SafetyOfficer => "Safety Officer",
                ApparatusType.CommandVan => "Command Van",
                ApparatusType.HazMatUnit => "Specialized Hazardous Material Unit",
                ApparatusType.TechnicalRescue => "Technical Rescue",
                ApparatusType.Unknown => "Unknown",

                _ => throw new NotImplementedException(),
            };
        }
        
    }
}
