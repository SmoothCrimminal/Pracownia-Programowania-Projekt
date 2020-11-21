// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/serverService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PracowniaProgramowaniaServer {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class PracowniaProgramowaniaServer
  {
    static readonly string __ServiceName = "serverService.PracowniaProgramowaniaServer";

    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.HelloRequest> __Marshaller_serverService_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.HelloReply> __Marshaller_serverService_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.HelloReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.CreateBrandRequest> __Marshaller_serverService_CreateBrandRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.CreateBrandRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.CreateBrandReply> __Marshaller_serverService_CreateBrandReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.CreateBrandReply.Parser.ParseFrom);

    static readonly grpc::Method<global::PracowniaProgramowaniaServer.HelloRequest, global::PracowniaProgramowaniaServer.HelloReply> __Method_SayHello = new grpc::Method<global::PracowniaProgramowaniaServer.HelloRequest, global::PracowniaProgramowaniaServer.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_serverService_HelloRequest,
        __Marshaller_serverService_HelloReply);

    static readonly grpc::Method<global::PracowniaProgramowaniaServer.CreateBrandRequest, global::PracowniaProgramowaniaServer.CreateBrandReply> __Method_CreateBrand = new grpc::Method<global::PracowniaProgramowaniaServer.CreateBrandRequest, global::PracowniaProgramowaniaServer.CreateBrandReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateBrand",
        __Marshaller_serverService_CreateBrandRequest,
        __Marshaller_serverService_CreateBrandReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PracowniaProgramowaniaServer.ServerServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PracowniaProgramowaniaServer</summary>
    [grpc::BindServiceMethod(typeof(PracowniaProgramowaniaServer), "BindService")]
    public abstract partial class PracowniaProgramowaniaServerBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::PracowniaProgramowaniaServer.HelloReply> SayHello(global::PracowniaProgramowaniaServer.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::PracowniaProgramowaniaServer.CreateBrandReply> CreateBrand(global::PracowniaProgramowaniaServer.CreateBrandRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PracowniaProgramowaniaServerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello)
          .AddMethod(__Method_CreateBrand, serviceImpl.CreateBrand).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PracowniaProgramowaniaServerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PracowniaProgramowaniaServer.HelloRequest, global::PracowniaProgramowaniaServer.HelloReply>(serviceImpl.SayHello));
      serviceBinder.AddMethod(__Method_CreateBrand, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PracowniaProgramowaniaServer.CreateBrandRequest, global::PracowniaProgramowaniaServer.CreateBrandReply>(serviceImpl.CreateBrand));
    }

  }
}
#endregion
