public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }
    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj)
    {
        if (obj is not FacialFeatures other) return false;
        return EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
    }
    public override int GetHashCode()
        => HashCode.Combine(EyeColor, PhiltrumWidth);   
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }
    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj)
    {
        if (obj is not Identity other) return false;
        return Email == other.Email &&
               Equals(FacialFeatures, other.FacialFeatures);
    }
public override int GetHashCode()
    => HashCode.Combine(Email, FacialFeatures.EyeColor, FacialFeatures.PhiltrumWidth);

}

public class Authenticator
{
    private static readonly FacialFeatures AdminFace = new FacialFeatures("green", 0.9m);
    private static readonly string AdminEmail = "admin@exerc.ism";

    private readonly HashSet<Identity> registered = new();

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
        => faceA.Equals(faceB);

    public bool IsAdmin(Identity identity)
        => identity.Email == AdminEmail && identity.FacialFeatures.Equals(AdminFace);

    public bool Register(Identity identity)
        => registered.Add(identity);

    public bool IsRegistered(Identity identity)
        => registered.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB)
          => ReferenceEquals(identityA, identityB);
}

