// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: serverService.proto
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
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.DeleteBrandRequest> __Marshaller_serverService_DeleteBrandRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.DeleteBrandRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.DeleteBrandReply> __Marshaller_serverService_DeleteBrandReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.DeleteBrandReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.ReadBrandRequest> __Marshaller_serverService_ReadBrandRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.ReadBrandRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.ReadBrandReply> __Marshaller_serverService_ReadBrandReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.ReadBrandReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.UpdateBrandRequest> __Marshaller_serverService_UpdateBrandRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.UpdateBrandRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.UpdateBrandReply> __Marshaller_serverService_UpdateBrandReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.UpdateBrandReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.CreateRoleRequest> __Marshaller_serverService_CreateRoleRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.CreateRoleRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.CreateRoleReply> __Marshaller_serverService_CreateRoleReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.CreateRoleReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.DeleteRoleRequest> __Marshaller_serverService_DeleteRoleRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.DeleteRoleRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.DeleteRoleReply> __Marshaller_serverService_DeleteRoleReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.DeleteRoleReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.ReadRoleRequest> __Marshaller_serverService_ReadRoleRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.ReadRoleRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.ReadRoleReply> __Marshaller_serverService_ReadRoleReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.ReadRoleReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.UpdateRoleRequest> __Marshaller_serverService_UpdateRoleRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.UpdateRoleRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::PracowniaProgramowaniaServer.UpdateRoleReply> __Marshaller_serverService_UpdateRoleReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::PracowniaProgramowaniaServer.UpdateRoleReply.Parser.ParseFrom);

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

    static readonly grpc::Method<global::PracowniaProgramowaniaServer.DeleteBrandRequest, global::PracowniaProgramowaniaServer.DeleteBrandReply> __Method_DeleteBrand = new grpc::Method<global::PracowniaProgramowaniaServer.DeleteBrandRequest, global::PracowniaProgramowaniaServer.DeleteBrandReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteBrand",
        __Marshaller_serverService_DeleteBrandRequest,
        __Marshaller_serverService_DeleteBrandReply);

    static readonly grpc::Method<global::PracowniaProgramowaniaServer.ReadBrandRequest, global::PracowniaProgramowaniaServer.ReadBrandReply> __Method_ReadBrand = new grpc::Method<global::PracowniaProgramowaniaServer.ReadBrandRequest, global::PracowniaProgramowaniaServer.ReadBrandReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadBrand",
        __Marshaller_serverService_ReadBrandRequest,
        __Marshaller_serverService_ReadBrandReply);

    static readonly grpc::Method<global::PracowniaProgramowaniaServer.UpdateBrandRequest, global::PracowniaProgramowaniaServer.UpdateBrandReply> __Method_UpdateBrand = new grpc::Method<global::PracowniaProgramowaniaServer.UpdateBrandRequest, global::PracowniaProgramowaniaServer.UpdateBrandReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateBrand",
        __Marshaller_serverService_UpdateBrandRequest,
        __Marshaller_serverService_UpdateBrandReply);

    static readonly grpc::Method<global::PracowniaProgramowaniaServer.CreateRoleRequest, global::PracowniaProgramowaniaServer.CreateRoleReply> __Method_CreateRole = new grpc::Method<global::PracowniaProgramowaniaServer.CreateRoleRequest, global::PracowniaProgramowaniaServer.CreateRoleReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateRole",
        __Marshaller_serverService_CreateRoleRequest,
        __Marshaller_serverService_CreateRoleReply);

    static readonly grpc::Method<global::PracowniaProgramowaniaServer.DeleteRoleRequest, global::PracowniaProgramowaniaServer.DeleteRoleReply> __Method_DeleteRole = new grpc::Method<global::PracowniaProgramowaniaServer.DeleteRoleRequest, global::PracowniaProgramowaniaServer.DeleteRoleReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteRole",
        __Marshaller_serverService_DeleteRoleRequest,
        __Marshaller_serverService_DeleteRoleReply);

    static readonly grpc::Method<global::PracowniaProgramowaniaServer.ReadRoleRequest, global::PracowniaProgramowaniaServer.ReadRoleReply> __Method_ReadRole = new grpc::Method<global::PracowniaProgramowaniaServer.ReadRoleRequest, global::PracowniaProgramowaniaServer.ReadRoleReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadRole",
        __Marshaller_serverService_ReadRoleRequest,
        __Marshaller_serverService_ReadRoleReply);

    static readonly grpc::Method<global::PracowniaProgramowaniaServer.UpdateRoleRequest, global::PracowniaProgramowaniaServer.UpdateRoleReply> __Method_UpdateRole = new grpc::Method<global::PracowniaProgramowaniaServer.UpdateRoleRequest, global::PracowniaProgramowaniaServer.UpdateRoleReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateRole",
        __Marshaller_serverService_UpdateRoleRequest,
        __Marshaller_serverService_UpdateRoleReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PracowniaProgramowaniaServer.ServerServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for PracowniaProgramowaniaServer</summary>
    public partial class PracowniaProgramowaniaServerClient : grpc::ClientBase<PracowniaProgramowaniaServerClient>
    {
      /// <summary>Creates a new client for PracowniaProgramowaniaServer</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PracowniaProgramowaniaServerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PracowniaProgramowaniaServer that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PracowniaProgramowaniaServerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PracowniaProgramowaniaServerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PracowniaProgramowaniaServerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::PracowniaProgramowaniaServer.HelloReply SayHello(global::PracowniaProgramowaniaServer.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::PracowniaProgramowaniaServer.HelloReply SayHello(global::PracowniaProgramowaniaServer.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.HelloReply> SayHelloAsync(global::PracowniaProgramowaniaServer.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.HelloReply> SayHelloAsync(global::PracowniaProgramowaniaServer.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual global::PracowniaProgramowaniaServer.CreateBrandReply CreateBrand(global::PracowniaProgramowaniaServer.CreateBrandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateBrand(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PracowniaProgramowaniaServer.CreateBrandReply CreateBrand(global::PracowniaProgramowaniaServer.CreateBrandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateBrand, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.CreateBrandReply> CreateBrandAsync(global::PracowniaProgramowaniaServer.CreateBrandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateBrandAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.CreateBrandReply> CreateBrandAsync(global::PracowniaProgramowaniaServer.CreateBrandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateBrand, null, options, request);
      }
      public virtual global::PracowniaProgramowaniaServer.DeleteBrandReply DeleteBrand(global::PracowniaProgramowaniaServer.DeleteBrandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteBrand(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PracowniaProgramowaniaServer.DeleteBrandReply DeleteBrand(global::PracowniaProgramowaniaServer.DeleteBrandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteBrand, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.DeleteBrandReply> DeleteBrandAsync(global::PracowniaProgramowaniaServer.DeleteBrandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteBrandAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.DeleteBrandReply> DeleteBrandAsync(global::PracowniaProgramowaniaServer.DeleteBrandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteBrand, null, options, request);
      }
      /// <summary>
      ///rpc ReadAllBrands (ReadAllBrandsRequest) returns (ReadAllBrandsReply);
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::PracowniaProgramowaniaServer.ReadBrandReply ReadBrand(global::PracowniaProgramowaniaServer.ReadBrandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadBrand(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///rpc ReadAllBrands (ReadAllBrandsRequest) returns (ReadAllBrandsReply);
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::PracowniaProgramowaniaServer.ReadBrandReply ReadBrand(global::PracowniaProgramowaniaServer.ReadBrandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReadBrand, null, options, request);
      }
      /// <summary>
      ///rpc ReadAllBrands (ReadAllBrandsRequest) returns (ReadAllBrandsReply);
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.ReadBrandReply> ReadBrandAsync(global::PracowniaProgramowaniaServer.ReadBrandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadBrandAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///rpc ReadAllBrands (ReadAllBrandsRequest) returns (ReadAllBrandsReply);
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.ReadBrandReply> ReadBrandAsync(global::PracowniaProgramowaniaServer.ReadBrandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReadBrand, null, options, request);
      }
      public virtual global::PracowniaProgramowaniaServer.UpdateBrandReply UpdateBrand(global::PracowniaProgramowaniaServer.UpdateBrandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateBrand(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PracowniaProgramowaniaServer.UpdateBrandReply UpdateBrand(global::PracowniaProgramowaniaServer.UpdateBrandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateBrand, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.UpdateBrandReply> UpdateBrandAsync(global::PracowniaProgramowaniaServer.UpdateBrandRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateBrandAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.UpdateBrandReply> UpdateBrandAsync(global::PracowniaProgramowaniaServer.UpdateBrandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateBrand, null, options, request);
      }
      public virtual global::PracowniaProgramowaniaServer.CreateRoleReply CreateRole(global::PracowniaProgramowaniaServer.CreateRoleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateRole(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PracowniaProgramowaniaServer.CreateRoleReply CreateRole(global::PracowniaProgramowaniaServer.CreateRoleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateRole, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.CreateRoleReply> CreateRoleAsync(global::PracowniaProgramowaniaServer.CreateRoleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateRoleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.CreateRoleReply> CreateRoleAsync(global::PracowniaProgramowaniaServer.CreateRoleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateRole, null, options, request);
      }
      public virtual global::PracowniaProgramowaniaServer.DeleteRoleReply DeleteRole(global::PracowniaProgramowaniaServer.DeleteRoleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteRole(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PracowniaProgramowaniaServer.DeleteRoleReply DeleteRole(global::PracowniaProgramowaniaServer.DeleteRoleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteRole, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.DeleteRoleReply> DeleteRoleAsync(global::PracowniaProgramowaniaServer.DeleteRoleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteRoleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.DeleteRoleReply> DeleteRoleAsync(global::PracowniaProgramowaniaServer.DeleteRoleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteRole, null, options, request);
      }
      /// <summary>
      ///rpc ReadAllBrands (ReadAllBrandsRequest) returns (ReadAllBrandsReply);
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::PracowniaProgramowaniaServer.ReadRoleReply ReadRole(global::PracowniaProgramowaniaServer.ReadRoleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadRole(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///rpc ReadAllBrands (ReadAllBrandsRequest) returns (ReadAllBrandsReply);
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::PracowniaProgramowaniaServer.ReadRoleReply ReadRole(global::PracowniaProgramowaniaServer.ReadRoleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReadRole, null, options, request);
      }
      /// <summary>
      ///rpc ReadAllBrands (ReadAllBrandsRequest) returns (ReadAllBrandsReply);
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.ReadRoleReply> ReadRoleAsync(global::PracowniaProgramowaniaServer.ReadRoleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadRoleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///rpc ReadAllBrands (ReadAllBrandsRequest) returns (ReadAllBrandsReply);
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.ReadRoleReply> ReadRoleAsync(global::PracowniaProgramowaniaServer.ReadRoleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReadRole, null, options, request);
      }
      public virtual global::PracowniaProgramowaniaServer.UpdateRoleReply UpdateRole(global::PracowniaProgramowaniaServer.UpdateRoleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateRole(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::PracowniaProgramowaniaServer.UpdateRoleReply UpdateRole(global::PracowniaProgramowaniaServer.UpdateRoleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateRole, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.UpdateRoleReply> UpdateRoleAsync(global::PracowniaProgramowaniaServer.UpdateRoleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateRoleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::PracowniaProgramowaniaServer.UpdateRoleReply> UpdateRoleAsync(global::PracowniaProgramowaniaServer.UpdateRoleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateRole, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PracowniaProgramowaniaServerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PracowniaProgramowaniaServerClient(configuration);
      }
    }

  }
}
#endregion
