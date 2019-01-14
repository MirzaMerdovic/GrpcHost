// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Customer.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Contracts {
  public static partial class CustomerService
  {
    static readonly string __ServiceName = "google.protobuf.CustomerService";

    static readonly grpc::Marshaller<global::Contracts.GetCustomerByIdRequest> __Marshaller_google_protobuf_GetCustomerByIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Contracts.GetCustomerByIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Contracts.GetCustomerByIdResponse> __Marshaller_google_protobuf_GetCustomerByIdResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Contracts.GetCustomerByIdResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Contracts.GetCustomerByIdRequest, global::Contracts.GetCustomerByIdResponse> __Method_GetCustomerById = new grpc::Method<global::Contracts.GetCustomerByIdRequest, global::Contracts.GetCustomerByIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerById",
        __Marshaller_google_protobuf_GetCustomerByIdRequest,
        __Marshaller_google_protobuf_GetCustomerByIdResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Contracts.CustomerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CustomerService</summary>
    public abstract partial class CustomerServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Contracts.GetCustomerByIdResponse> GetCustomerById(global::Contracts.GetCustomerByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CustomerService</summary>
    public partial class CustomerServiceClient : grpc::ClientBase<CustomerServiceClient>
    {
      /// <summary>Creates a new client for CustomerService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CustomerServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CustomerService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CustomerServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CustomerServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CustomerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Contracts.GetCustomerByIdResponse GetCustomerById(global::Contracts.GetCustomerByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Contracts.GetCustomerByIdResponse GetCustomerById(global::Contracts.GetCustomerByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCustomerById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Contracts.GetCustomerByIdResponse> GetCustomerByIdAsync(global::Contracts.GetCustomerByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Contracts.GetCustomerByIdResponse> GetCustomerByIdAsync(global::Contracts.GetCustomerByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCustomerById, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CustomerServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CustomerServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CustomerServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCustomerById, serviceImpl.GetCustomerById).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomerServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCustomerById, serviceImpl.GetCustomerById);
    }

  }
}
#endregion
