using Csml;


partial class Tutorials : Scope {
    public static LanguageSelector<IMaterial> TrackingMinimalDemoCSharp => new LanguageSelector<IMaterial>();
    public partial class TrackingMinimalDemoCSharp_Assets : Scope {
        
        public static Image TitleImage => new Image("./TitleImage.jpg");
        
    }



}