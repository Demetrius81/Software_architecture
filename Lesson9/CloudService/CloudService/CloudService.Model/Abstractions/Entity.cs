﻿using CloudService.Interfaces;

namespace CloudService.Model.Abstractions;

/// <summary>
/// ААбстракция сущности
/// </summary>
public abstract class Entity : IEntity
{
    public int Id { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType()) return false;
        return ReferenceEquals(this, obj) ? true : Equals((Entity)obj);
    }

    public bool Equals(Entity? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Id == other.Id;
    }

    public override int GetHashCode() => Id;

    public abstract object Clone();

    public static bool operator ==(Entity? left, Entity? right) => Equals(left, right);

    public static bool operator !=(Entity? left, Entity? right) => !Equals(left, right);
}
