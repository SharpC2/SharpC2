using System;

[Serializable]
public class AgentMessage
{
    public string IdempotencyKey { get; set; } = Guid.NewGuid().ToString();
    public AgentMetadata Metadata { get; set; } = new AgentMetadata();
    public C2Data Data { get; set; } = new C2Data();
}

[Serializable]
public class C2Data
{
    public string AgentID { get; set; } = "";
    public string Module { get; set; } = "";
    public string Command { get; set; } = "";
    public byte[] Data { get; set; } = new byte[] { };
}

[Serializable]
public class AgentMetadata
{
    public string AgentID { get; set; } = "";
    public string ParentAgentID { get; set; } = "";
    public string Hostname { get; set; } = "";
    public string IPAddress { get; set; } = "";
    public string Identity { get; set; } = "";
    public string ProcessName { get; set; } = "";
    public int ProcessID { get; set; } = 0;
    public Arch Arch { get; set; } = Arch.Unknown;
    public Integrity Integrity { get; set; } = Integrity.Unknown;
    public int CLR { get; set; } = 0;
}

public enum Arch
{
    x64,
    x86,
    Unknown
}

public enum Integrity
{
    Medium,
    High,
    SYSTEM,
    Unknown
}