﻿using System;
using System.Collections.Concurrent;
using SiliconStudio.Core.Storage;

namespace SiliconStudio.Core.Serialization
{
    /// <summary>
    /// Simple serializer that will matches specific type using base type and create a data serializer with matched type.
    /// </summary>
    public class GenericSerializerFactory : SerializerFactory
    {
        private readonly Type baseType;
        private readonly Type serializerGenericType;
        private readonly ConcurrentDictionary<Type, DataSerializer> serializersByType = new ConcurrentDictionary<Type, DataSerializer>();
        private readonly ConcurrentDictionary<ObjectId, DataSerializer> serializersByTypeId = new ConcurrentDictionary<ObjectId, DataSerializer>();

        /// <summary>
        /// Initializes a new instance of the type <see cref="GenericSerializerFactory"/>.
        /// </summary>
        /// <param name="baseType">The type to match.</param>
        /// <param name="serializerGenericType">The generic type that will be used to instantiate serializers.</param>
        public GenericSerializerFactory(Type baseType, Type serializerGenericType)
        {
            this.baseType = baseType;
            this.serializerGenericType = serializerGenericType;
        }

        public override DataSerializer GetSerializer(SerializerSelector selector, ref ObjectId typeId)
        {
            DataSerializer dataSerializer;
            serializersByTypeId.TryGetValue(typeId, out dataSerializer);
            return dataSerializer;
        }

        public override DataSerializer GetSerializer(SerializerSelector selector, Type type)
        {
            DataSerializer dataSerializer;
            if (!serializersByType.TryGetValue(type, out dataSerializer))
            {
                if (baseType.IsAssignableFrom(type))
                {
                    dataSerializer = (DataSerializer)Activator.CreateInstance(serializerGenericType.MakeGenericType(type));
                    selector.EnsureInitialized(dataSerializer);
                    serializersByTypeId.TryAdd(dataSerializer.SerializationTypeId, dataSerializer);
                }
                // Add it even if null (so that failures are cached too)
                serializersByType.TryAdd(type, dataSerializer);
            }
            return dataSerializer;
        }
    }
}