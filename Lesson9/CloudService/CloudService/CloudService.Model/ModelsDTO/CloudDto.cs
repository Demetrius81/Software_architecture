﻿using CloudService.Model.Abstractions;

namespace CloudService.Model.ModelsDTO;
public class CloudDto : Entity
{
    public Client? CurrentClient { get; set; }
    public IpAddress? CurrentIpAddress { get; set; }
    public ServerPool? CurrentServerPool { get; set; }
    public int Ram { get; set; }
    public int Rom { get; set; }
    public int Cpu { get; set; }
    public OperationSystem Os { get; set; }
}
