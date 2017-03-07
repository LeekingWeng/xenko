//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: This file contains C#/managed code bindings for the OpenVR interfaces
// This file is auto-generated, do not edit it.
//
//=============================================================================

using System;
using System.Runtime.InteropServices;
using Valve.VR;

namespace Valve.VR
{

[StructLayout(LayoutKind.Sequential)]
internal struct IVRSystem
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRecommendedRenderTargetSize GetRecommendedRenderTargetSize;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdMatrix44_t _GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ, EGraphicsAPIConvention eProjType);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetProjectionMatrix GetProjectionMatrix;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetProjectionRaw GetProjectionRaw;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ComputeDistortion ComputeDistortion;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdMatrix34_t _GetEyeToHeadTransform(EVREye eEye);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetEyeToHeadTransform GetEyeToHeadTransform;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTimeSinceLastVsync GetTimeSinceLastVsync;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int _GetD3D9AdapterIndex();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetD3D9AdapterIndex GetD3D9AdapterIndex;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDXGIOutputInfo GetDXGIOutputInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsDisplayOnDesktop();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsDisplayOnDesktop IsDisplayOnDesktop;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _SetDisplayVisibility(bool bIsVisibleOnDesktop);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetDisplayVisibility SetDisplayVisibility;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, [In, Out] TrackedDevicePose_t[] pTrackedDevicePoseArray, uint unTrackedDevicePoseArrayCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDeviceToAbsoluteTrackingPose GetDeviceToAbsoluteTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ResetSeatedZeroPose();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ResetSeatedZeroPose ResetSeatedZeroPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdMatrix34_t _GetSeatedZeroPoseToStandingAbsoluteTrackingPose();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSeatedZeroPoseToStandingAbsoluteTrackingPose GetSeatedZeroPoseToStandingAbsoluteTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdMatrix34_t _GetRawZeroPoseToStandingAbsoluteTrackingPose();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRawZeroPoseToStandingAbsoluteTrackingPose GetRawZeroPoseToStandingAbsoluteTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, [In, Out] uint[] punTrackedDeviceIndexArray, uint unTrackedDeviceIndexArrayCount, uint unRelativeToTrackedDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSortedTrackedDeviceIndicesOfClass GetSortedTrackedDeviceIndicesOfClass;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EDeviceActivityLevel _GetTrackedDeviceActivityLevel(uint unDeviceId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTrackedDeviceActivityLevel GetTrackedDeviceActivityLevel;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ApplyTransform ApplyTransform;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTrackedDeviceIndexForControllerRole GetTrackedDeviceIndexForControllerRole;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackedControllerRole _GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetControllerRoleForTrackedDeviceIndex GetControllerRoleForTrackedDeviceIndex;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackedDeviceClass _GetTrackedDeviceClass(uint unDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTrackedDeviceClass GetTrackedDeviceClass;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsTrackedDeviceConnected(uint unDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsTrackedDeviceConnected IsTrackedDeviceConnected;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetBoolTrackedDeviceProperty GetBoolTrackedDeviceProperty;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate float _GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFloatTrackedDeviceProperty GetFloatTrackedDeviceProperty;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int _GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetInt32TrackedDeviceProperty GetInt32TrackedDeviceProperty;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetUint64TrackedDeviceProperty GetUint64TrackedDeviceProperty;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdMatrix34_t _GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetMatrix34TrackedDeviceProperty GetMatrix34TrackedDeviceProperty;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, System.Text.StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetStringTrackedDeviceProperty GetStringTrackedDeviceProperty;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetPropErrorNameFromEnum(ETrackedPropertyError error);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PollNextEvent PollNextEvent;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PollNextEventWithPose PollNextEventWithPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetEventTypeNameFromEnum(EVREventType eType);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetEventTypeNameFromEnum GetEventTypeNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HiddenAreaMesh_t _GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetHiddenAreaMesh GetHiddenAreaMesh;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetControllerState GetControllerState;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetControllerStateWithPose GetControllerStateWithPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, char usDurationMicroSec);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _TriggerHapticPulse TriggerHapticPulse;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetButtonIdNameFromEnum(EVRButtonId eButtonId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetButtonIdNameFromEnum GetButtonIdNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetControllerAxisTypeNameFromEnum GetControllerAxisTypeNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _CaptureInputFocus();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CaptureInputFocus CaptureInputFocus;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ReleaseInputFocus();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseInputFocus ReleaseInputFocus;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsInputFocusCapturedByAnotherProcess();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsInputFocusCapturedByAnotherProcess IsInputFocusCapturedByAnotherProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _DriverDebugRequest(uint unDeviceIndex, string pchRequest, string pchResponseBuffer, uint unResponseBufferSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _DriverDebugRequest DriverDebugRequest;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRFirmwareError _PerformFirmwareUpdate(uint unDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PerformFirmwareUpdate PerformFirmwareUpdate;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _AcknowledgeQuit_Exiting();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AcknowledgeQuit_Exiting AcknowledgeQuit_Exiting;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _AcknowledgeQuit_UserPrompt();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AcknowledgeQuit_UserPrompt AcknowledgeQuit_UserPrompt;

}

[StructLayout(LayoutKind.Sequential)]
internal struct IVRExtendedDisplay
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWindowBounds GetWindowBounds;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetEyeOutputViewport GetEyeOutputViewport;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDXGIOutputInfo GetDXGIOutputInfo;

}

[StructLayout(LayoutKind.Sequential)]
internal struct IVRTrackedCamera
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraErrorNameFromEnum GetCameraErrorNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _HasCamera(uint nDeviceIndex, ref bool pHasCamera);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HasCamera HasCamera;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetCameraFrameSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref uint pnWidth, ref uint pnHeight, ref uint pnFrameBufferSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraFrameSize GetCameraFrameSize;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetCameraIntrinisics(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref HmdVector2_t pFocalLength, ref HmdVector2_t pCenter);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraIntrinisics GetCameraIntrinisics;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetCameraProjection(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, float flZNear, float flZFar, ref HmdMatrix44_t pProjection);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraProjection GetCameraProjection;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _AcquireVideoStreamingService(uint nDeviceIndex, ref ulong pHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AcquireVideoStreamingService AcquireVideoStreamingService;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _ReleaseVideoStreamingService(ulong hTrackedCamera);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseVideoStreamingService ReleaseVideoStreamingService;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetVideoStreamFrameBuffer(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pFrameBuffer, uint nFrameBufferSize, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVideoStreamFrameBuffer GetVideoStreamFrameBuffer;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetVideoStreamTextureSize(uint nDeviceIndex, EVRTrackedCameraFrameType eFrameType, ref VRTextureBounds_t pTextureBounds, ref uint pnWidth, ref uint pnHeight);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVideoStreamTextureSize GetVideoStreamTextureSize;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetVideoStreamTextureD3D11(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVideoStreamTextureD3D11 GetVideoStreamTextureD3D11;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _GetVideoStreamTextureGL(ulong hTrackedCamera, EVRTrackedCameraFrameType eFrameType, ref uint pglTextureId, ref CameraVideoStreamFrameHeader_t pFrameHeader, uint nFrameHeaderSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVideoStreamTextureGL GetVideoStreamTextureGL;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRTrackedCameraError _ReleaseVideoStreamTextureGL(ulong hTrackedCamera, uint glTextureId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseVideoStreamTextureGL ReleaseVideoStreamTextureGL;

}

[StructLayout(LayoutKind.Sequential)]
internal struct IVRApplications
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AddApplicationManifest AddApplicationManifest;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _RemoveApplicationManifest(string pchApplicationManifestFullPath);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RemoveApplicationManifest RemoveApplicationManifest;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsApplicationInstalled(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsApplicationInstalled IsApplicationInstalled;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationCount();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationCount GetApplicationCount;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _GetApplicationKeyByIndex(uint unApplicationIndex, System.Text.StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationKeyByIndex GetApplicationKeyByIndex;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _GetApplicationKeyByProcessId(uint unProcessId, string pchAppKeyBuffer, uint unAppKeyBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationKeyByProcessId GetApplicationKeyByProcessId;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchApplication(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchApplication LaunchApplication;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, [In, Out] AppOverrideKeys_t[] pKeys, uint unKeys);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchTemplateApplication LaunchTemplateApplication;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchApplicationFromMimeType(string pchMimeType, string pchArgs);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchApplicationFromMimeType LaunchApplicationFromMimeType;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchDashboardOverlay(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchDashboardOverlay LaunchDashboardOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _CancelApplicationLaunch(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CancelApplicationLaunch CancelApplicationLaunch;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _IdentifyApplication(uint unProcessId, string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IdentifyApplication IdentifyApplication;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationProcessId(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationProcessId GetApplicationProcessId;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetApplicationsErrorNameFromEnum(EVRApplicationError error);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationsErrorNameFromEnum GetApplicationsErrorNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, System.Text.StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationPropertyString GetApplicationPropertyString;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationPropertyBool GetApplicationPropertyBool;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationPropertyUint64 GetApplicationPropertyUint64;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetApplicationAutoLaunch SetApplicationAutoLaunch;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetApplicationAutoLaunch(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationAutoLaunch GetApplicationAutoLaunch;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetDefaultApplicationForMimeType SetDefaultApplicationForMimeType;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetDefaultApplicationForMimeType(string pchMimeType, string pchAppKeyBuffer, uint unAppKeyBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDefaultApplicationForMimeType GetDefaultApplicationForMimeType;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetApplicationSupportedMimeTypes(string pchAppKey, string pchMimeTypesBuffer, uint unMimeTypesBuffer);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationSupportedMimeTypes GetApplicationSupportedMimeTypes;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationsThatSupportMimeType(string pchMimeType, string pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationsThatSupportMimeType GetApplicationsThatSupportMimeType;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationLaunchArguments(uint unHandle, string pchArgs, uint unArgs);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationLaunchArguments GetApplicationLaunchArguments;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _GetStartingApplication(string pchAppKeyBuffer, uint unAppKeyBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetStartingApplication GetStartingApplication;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationTransitionState _GetTransitionState();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTransitionState GetTransitionState;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _PerformApplicationPrelaunchCheck(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PerformApplicationPrelaunchCheck PerformApplicationPrelaunchCheck;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationsTransitionStateNameFromEnum GetApplicationsTransitionStateNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsQuitUserPromptRequested();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsQuitUserPromptRequested IsQuitUserPromptRequested;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchInternalProcess LaunchInternalProcess;

}

[StructLayout(LayoutKind.Sequential)]
internal struct IVRChaperone
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ChaperoneCalibrationState _GetCalibrationState();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCalibrationState GetCalibrationState;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetPlayAreaSize(ref float pSizeX, ref float pSizeZ);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetPlayAreaSize GetPlayAreaSize;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetPlayAreaRect(ref HmdQuad_t rect);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetPlayAreaRect GetPlayAreaRect;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ReloadInfo();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReloadInfo ReloadInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetSceneColor(HmdColor_t color);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetSceneColor SetSceneColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetBoundsColor GetBoundsColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _AreBoundsVisible();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AreBoundsVisible AreBoundsVisible;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ForceBoundsVisible(bool bForce);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ForceBoundsVisible ForceBoundsVisible;

}

[StructLayout(LayoutKind.Sequential)]
internal struct IVRChaperoneSetup
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _CommitWorkingCopy(EChaperoneConfigFile configFile);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CommitWorkingCopy CommitWorkingCopy;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _RevertWorkingCopy();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RevertWorkingCopy RevertWorkingCopy;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingPlayAreaSize GetWorkingPlayAreaSize;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingPlayAreaRect(ref HmdQuad_t rect);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingPlayAreaRect GetWorkingPlayAreaRect;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingCollisionBoundsInfo GetWorkingCollisionBoundsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetLiveCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLiveCollisionBoundsInfo GetLiveCollisionBoundsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingSeatedZeroPoseToRawTrackingPose GetWorkingSeatedZeroPoseToRawTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingStandingZeroPoseToRawTrackingPose GetWorkingStandingZeroPoseToRawTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingPlayAreaSize(float sizeX, float sizeZ);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingPlayAreaSize SetWorkingPlayAreaSize;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingCollisionBoundsInfo SetWorkingCollisionBoundsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingSeatedZeroPoseToRawTrackingPose SetWorkingSeatedZeroPoseToRawTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingStandingZeroPoseToRawTrackingPose SetWorkingStandingZeroPoseToRawTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ReloadFromDisk(EChaperoneConfigFile configFile);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReloadFromDisk ReloadFromDisk;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLiveSeatedZeroPoseToRawTrackingPose GetLiveSeatedZeroPoseToRawTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingCollisionBoundsTagsInfo([In, Out] byte[] pTagsBuffer, uint unTagCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingCollisionBoundsTagsInfo SetWorkingCollisionBoundsTagsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetLiveCollisionBoundsTagsInfo([In, Out] byte[] pTagsBuffer, ref uint punTagCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLiveCollisionBoundsTagsInfo GetLiveCollisionBoundsTagsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _SetWorkingPhysicalBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingPhysicalBoundsInfo SetWorkingPhysicalBoundsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetLivePhysicalBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLivePhysicalBoundsInfo GetLivePhysicalBoundsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ExportLiveToBuffer(System.Text.StringBuilder pBuffer, ref uint pnBufferLength);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ExportLiveToBuffer ExportLiveToBuffer;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ImportFromBufferToWorking(string pBuffer, uint nImportFlags);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ImportFromBufferToWorking ImportFromBufferToWorking;

}

[StructLayout(LayoutKind.Sequential)]
internal struct IVRCompositor
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetTrackingSpace(ETrackingUniverseOrigin eOrigin);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetTrackingSpace SetTrackingSpace;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackingUniverseOrigin _GetTrackingSpace();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTrackingSpace GetTrackingSpace;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _WaitGetPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _WaitGetPoses WaitGetPoses;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetLastPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLastPoses GetLastPoses;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLastPoseForTrackedDeviceIndex GetLastPoseForTrackedDeviceIndex;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _Submit Submit;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ClearLastSubmittedFrame();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ClearLastSubmittedFrame ClearLastSubmittedFrame;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _PostPresentHandoff();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PostPresentHandoff PostPresentHandoff;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFrameTiming GetFrameTiming;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetFrameTimings(ref Compositor_FrameTiming pTiming, uint nFrames);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFrameTimings GetFrameTimings;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate float _GetFrameTimeRemaining();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFrameTimeRemaining GetFrameTimeRemaining;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCumulativeStats GetCumulativeStats;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FadeToColor FadeToColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdColor_t _GetCurrentFadeColor(bool bBackground);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCurrentFadeColor GetCurrentFadeColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FadeGrid(float fSeconds, bool bFadeIn);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FadeGrid FadeGrid;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate float _GetCurrentGridAlpha();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCurrentGridAlpha GetCurrentGridAlpha;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _SetSkyboxOverride([In, Out] Texture_t[] pTextures, uint unTextureCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetSkyboxOverride SetSkyboxOverride;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ClearSkyboxOverride();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ClearSkyboxOverride ClearSkyboxOverride;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CompositorBringToFront();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CompositorBringToFront CompositorBringToFront;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CompositorGoToBack();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CompositorGoToBack CompositorGoToBack;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CompositorQuit();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CompositorQuit CompositorQuit;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsFullscreen();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsFullscreen IsFullscreen;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetCurrentSceneFocusProcess();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCurrentSceneFocusProcess GetCurrentSceneFocusProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetLastFrameRenderer();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLastFrameRenderer GetLastFrameRenderer;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _CanRenderScene();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CanRenderScene CanRenderScene;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ShowMirrorWindow();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowMirrorWindow ShowMirrorWindow;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _HideMirrorWindow();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HideMirrorWindow HideMirrorWindow;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsMirrorWindowVisible();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsMirrorWindowVisible IsMirrorWindowVisible;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CompositorDumpImages();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CompositorDumpImages CompositorDumpImages;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ShouldAppRenderWithLowResources();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShouldAppRenderWithLowResources ShouldAppRenderWithLowResources;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ForceInterleavedReprojectionOn(bool bOverride);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ForceInterleavedReprojectionOn ForceInterleavedReprojectionOn;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ForceReconnectProcess();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ForceReconnectProcess ForceReconnectProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SuspendRendering(bool bSuspend);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SuspendRendering SuspendRendering;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetMirrorTextureD3D11 GetMirrorTextureD3D11;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetMirrorTextureGL GetMirrorTextureGL;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseSharedGLTexture ReleaseSharedGLTexture;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LockGLSharedTextureForAccess LockGLSharedTextureForAccess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _UnlockGLSharedTextureForAccess UnlockGLSharedTextureForAccess;

}

[StructLayout(LayoutKind.Sequential)]
internal struct IVROverlay
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FindOverlay FindOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _CreateOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CreateOverlay CreateOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _DestroyOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _DestroyOverlay DestroyOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetHighQualityOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetHighQualityOverlay SetHighQualityOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetHighQualityOverlay();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetHighQualityOverlay GetHighQualityOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetOverlayKey(ulong ulOverlayHandle, System.Text.StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayKey GetOverlayKey;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetOverlayName(ulong ulOverlayHandle, System.Text.StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayName GetOverlayName;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayImageData GetOverlayImageData;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetOverlayErrorNameFromEnum(EVROverlayError error);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayErrorNameFromEnum GetOverlayErrorNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayRenderingPid SetOverlayRenderingPid;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetOverlayRenderingPid(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayRenderingPid GetOverlayRenderingPid;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayFlag SetOverlayFlag;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayFlag GetOverlayFlag;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayColor SetOverlayColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayColor GetOverlayColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayAlpha SetOverlayAlpha;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayAlpha GetOverlayAlpha;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTexelAspect SetOverlayTexelAspect;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTexelAspect GetOverlayTexelAspect;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlaySortOrder SetOverlaySortOrder;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlaySortOrder GetOverlaySortOrder;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayWidthInMeters SetOverlayWidthInMeters;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayWidthInMeters GetOverlayWidthInMeters;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayAutoCurveDistanceRangeInMeters SetOverlayAutoCurveDistanceRangeInMeters;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayAutoCurveDistanceRangeInMeters GetOverlayAutoCurveDistanceRangeInMeters;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTextureColorSpace SetOverlayTextureColorSpace;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTextureColorSpace GetOverlayTextureColorSpace;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTextureBounds SetOverlayTextureBounds;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTextureBounds GetOverlayTextureBounds;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformType GetOverlayTransformType;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTransformAbsolute SetOverlayTransformAbsolute;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformAbsolute GetOverlayTransformAbsolute;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTransformTrackedDeviceRelative SetOverlayTransformTrackedDeviceRelative;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformTrackedDeviceRelative GetOverlayTransformTrackedDeviceRelative;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTransformTrackedDeviceComponent SetOverlayTransformTrackedDeviceComponent;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, string pchComponentName, uint unComponentNameSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformTrackedDeviceComponent GetOverlayTransformTrackedDeviceComponent;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ShowOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowOverlay ShowOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _HideOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HideOverlay HideOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsOverlayVisible(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsOverlayVisible IsOverlayVisible;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTransformForOverlayCoordinates GetTransformForOverlayCoordinates;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PollNextOverlayEvent PollNextOverlayEvent;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayInputMethod GetOverlayInputMethod;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayInputMethod SetOverlayInputMethod;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayMouseScale GetOverlayMouseScale;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayMouseScale SetOverlayMouseScale;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ComputeOverlayIntersection ComputeOverlayIntersection;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _HandleControllerOverlayInteractionAsMouse(ulong ulOverlayHandle, uint unControllerDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HandleControllerOverlayInteractionAsMouse HandleControllerOverlayInteractionAsMouse;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsHoverTargetOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsHoverTargetOverlay IsHoverTargetOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetGamepadFocusOverlay();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetGamepadFocusOverlay GetGamepadFocusOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetGamepadFocusOverlay(ulong ulNewFocusOverlay);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetGamepadFocusOverlay SetGamepadFocusOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayNeighbor(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayNeighbor SetOverlayNeighbor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _MoveGamepadFocusToNeighbor(EOverlayDirection eDirection, ulong ulFrom);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _MoveGamepadFocusToNeighbor MoveGamepadFocusToNeighbor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTexture SetOverlayTexture;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ClearOverlayTexture(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ClearOverlayTexture ClearOverlayTexture;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayRaw SetOverlayRaw;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayFromFile SetOverlayFromFile;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref EGraphicsAPIConvention pAPI, ref EColorSpace pColorSpace);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTexture GetOverlayTexture;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseNativeOverlayHandle ReleaseNativeOverlayHandle;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTextureSize GetOverlayTextureSize;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CreateDashboardOverlay CreateDashboardOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsDashboardVisible();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsDashboardVisible IsDashboardVisible;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsActiveDashboardOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsActiveDashboardOverlay IsActiveDashboardOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetDashboardOverlaySceneProcess SetDashboardOverlaySceneProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDashboardOverlaySceneProcess GetDashboardOverlaySceneProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ShowDashboard(string pchOverlayToShow);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowDashboard ShowDashboard;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetPrimaryDashboardDevice();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetPrimaryDashboardDevice GetPrimaryDashboardDevice;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowKeyboard ShowKeyboard;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowKeyboardForOverlay ShowKeyboardForOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetKeyboardText(System.Text.StringBuilder pchText, uint cchText);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetKeyboardText GetKeyboardText;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _HideKeyboard();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HideKeyboard HideKeyboard;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetKeyboardTransformAbsolute SetKeyboardTransformAbsolute;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetKeyboardPositionForOverlay SetKeyboardPositionForOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayIntersectionMask SetOverlayIntersectionMask;

}

[StructLayout(LayoutKind.Sequential)]
internal struct IVRRenderModels
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRRenderModelError _LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LoadRenderModel_Async LoadRenderModel_Async;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FreeRenderModel(IntPtr pRenderModel);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FreeRenderModel FreeRenderModel;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRRenderModelError _LoadTexture_Async(int textureId, ref IntPtr ppTexture);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LoadTexture_Async LoadTexture_Async;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FreeTexture(IntPtr pTexture);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FreeTexture FreeTexture;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRRenderModelError _LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LoadTextureD3D11_Async LoadTextureD3D11_Async;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRRenderModelError _LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LoadIntoTextureD3D11_Async LoadIntoTextureD3D11_Async;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FreeTextureD3D11(IntPtr pD3D11Texture2D);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FreeTextureD3D11 FreeTextureD3D11;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetRenderModelName(uint unRenderModelIndex, System.Text.StringBuilder pchRenderModelName, uint unRenderModelNameLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRenderModelName GetRenderModelName;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetRenderModelCount();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRenderModelCount GetRenderModelCount;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetComponentCount(string pchRenderModelName);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetComponentCount GetComponentCount;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetComponentName(string pchRenderModelName, uint unComponentIndex, System.Text.StringBuilder pchComponentName, uint unComponentNameLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetComponentName GetComponentName;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetComponentButtonMask(string pchRenderModelName, string pchComponentName);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetComponentButtonMask GetComponentButtonMask;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, System.Text.StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetComponentRenderModelName GetComponentRenderModelName;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetComponentState GetComponentState;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _RenderModelHasComponent(string pchRenderModelName, string pchComponentName);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RenderModelHasComponent RenderModelHasComponent;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetRenderModelThumbnailURL(string pchRenderModelName, System.Text.StringBuilder pchThumbnailURL, uint unThumbnailURLLen, ref EVRRenderModelError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRenderModelThumbnailURL GetRenderModelThumbnailURL;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetRenderModelOriginalPath(string pchRenderModelName, System.Text.StringBuilder pchOriginalPath, uint unOriginalPathLen, ref EVRRenderModelError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRenderModelOriginalPath GetRenderModelOriginalPath;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetRenderModelErrorNameFromEnum(EVRRenderModelError error);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRenderModelErrorNameFromEnum GetRenderModelErrorNameFromEnum;

}

[StructLayout(LayoutKind.Sequential)]
internal struct IVRNotifications
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRNotificationError _CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CreateNotification CreateNotification;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRNotificationError _RemoveNotification(uint notificationId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RemoveNotification RemoveNotification;

}

[StructLayout(LayoutKind.Sequential)]
internal struct IVRSettings
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetSettingsErrorNameFromEnum(EVRSettingsError eError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSettingsErrorNameFromEnum GetSettingsErrorNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _Sync(bool bForce, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _Sync Sync;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetBool SetBool;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetInt32 SetInt32;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetFloat SetFloat;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetString SetString;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetBool(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetBool GetBool;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int _GetInt32(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetInt32 GetInt32;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate float _GetFloat(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFloat GetFloat;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetString(string pchSection, string pchSettingsKey, System.Text.StringBuilder pchValue, uint unValueLen, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetString GetString;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _RemoveSection(string pchSection, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RemoveSection RemoveSection;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RemoveKeyInSection RemoveKeyInSection;

}

[StructLayout(LayoutKind.Sequential)]
internal struct IVRScreenshots
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRScreenshotError _RequestScreenshot(ref uint pOutScreenshotHandle, EVRScreenshotType type, string pchPreviewFilename, string pchVRFilename);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RequestScreenshot RequestScreenshot;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRScreenshotError _HookScreenshot([In, Out] EVRScreenshotType[] pSupportedTypes, int numTypes);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HookScreenshot HookScreenshot;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRScreenshotType _GetScreenshotPropertyType(uint screenshotHandle, ref EVRScreenshotError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetScreenshotPropertyType GetScreenshotPropertyType;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetScreenshotPropertyFilename(uint screenshotHandle, EVRScreenshotPropertyFilenames filenameType, System.Text.StringBuilder pchFilename, uint cchFilename, ref EVRScreenshotError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetScreenshotPropertyFilename GetScreenshotPropertyFilename;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRScreenshotError _UpdateScreenshotProgress(uint screenshotHandle, float flProgress);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _UpdateScreenshotProgress UpdateScreenshotProgress;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRScreenshotError _TakeStereoScreenshot(ref uint pOutScreenshotHandle, string pchPreviewFilename, string pchVRFilename);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _TakeStereoScreenshot TakeStereoScreenshot;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRScreenshotError _SubmitScreenshot(uint screenshotHandle, EVRScreenshotType type, string pchSourcePreviewFilename, string pchSourceVRFilename);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SubmitScreenshot SubmitScreenshot;

}

[StructLayout(LayoutKind.Sequential)]
internal struct IVRResources
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _LoadSharedResource(string pchResourceName, string pchBuffer, uint unBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LoadSharedResource LoadSharedResource;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetResourceFullPath(string pchResourceName, string pchResourceTypeDirectory, string pchPathBuffer, uint unBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetResourceFullPath GetResourceFullPath;

}


internal class CVRSystem
{
	IVRSystem FnTable;
	internal CVRSystem(IntPtr pInterface)
	{
		FnTable = (IVRSystem)Marshal.PtrToStructure(pInterface, typeof(IVRSystem));
	}
	internal void GetRecommendedRenderTargetSize(ref uint pnWidth,ref uint pnHeight)
	{
		pnWidth = 0;
		pnHeight = 0;
		FnTable.GetRecommendedRenderTargetSize(ref pnWidth,ref pnHeight);
	}
	internal HmdMatrix44_t GetProjectionMatrix(EVREye eEye,float fNearZ,float fFarZ,EGraphicsAPIConvention eProjType)
	{
		HmdMatrix44_t result = FnTable.GetProjectionMatrix(eEye,fNearZ,fFarZ,eProjType);
		return result;
	}
	internal void GetProjectionRaw(EVREye eEye,ref float pfLeft,ref float pfRight,ref float pfTop,ref float pfBottom)
	{
		pfLeft = 0;
		pfRight = 0;
		pfTop = 0;
		pfBottom = 0;
		FnTable.GetProjectionRaw(eEye,ref pfLeft,ref pfRight,ref pfTop,ref pfBottom);
	}
	internal bool ComputeDistortion(EVREye eEye,float fU,float fV,ref DistortionCoordinates_t pDistortionCoordinates)
	{
		bool result = FnTable.ComputeDistortion(eEye,fU,fV,ref pDistortionCoordinates);
		return result;
	}
	internal HmdMatrix34_t GetEyeToHeadTransform(EVREye eEye)
	{
		HmdMatrix34_t result = FnTable.GetEyeToHeadTransform(eEye);
		return result;
	}
	internal bool GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync,ref ulong pulFrameCounter)
	{
		pfSecondsSinceLastVsync = 0;
		pulFrameCounter = 0;
		bool result = FnTable.GetTimeSinceLastVsync(ref pfSecondsSinceLastVsync,ref pulFrameCounter);
		return result;
	}
	internal int GetD3D9AdapterIndex()
	{
		int result = FnTable.GetD3D9AdapterIndex();
		return result;
	}
	internal void GetDXGIOutputInfo(ref int pnAdapterIndex)
	{
		pnAdapterIndex = 0;
		FnTable.GetDXGIOutputInfo(ref pnAdapterIndex);
	}
	internal bool IsDisplayOnDesktop()
	{
		bool result = FnTable.IsDisplayOnDesktop();
		return result;
	}
	internal bool SetDisplayVisibility(bool bIsVisibleOnDesktop)
	{
		bool result = FnTable.SetDisplayVisibility(bIsVisibleOnDesktop);
		return result;
	}
	internal void GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin,float fPredictedSecondsToPhotonsFromNow,TrackedDevicePose_t [] pTrackedDevicePoseArray)
	{
		FnTable.GetDeviceToAbsoluteTrackingPose(eOrigin,fPredictedSecondsToPhotonsFromNow,pTrackedDevicePoseArray,(uint) pTrackedDevicePoseArray.Length);
	}
	internal void ResetSeatedZeroPose()
	{
		FnTable.ResetSeatedZeroPose();
	}
	internal HmdMatrix34_t GetSeatedZeroPoseToStandingAbsoluteTrackingPose()
	{
		HmdMatrix34_t result = FnTable.GetSeatedZeroPoseToStandingAbsoluteTrackingPose();
		return result;
	}
	internal HmdMatrix34_t GetRawZeroPoseToStandingAbsoluteTrackingPose()
	{
		HmdMatrix34_t result = FnTable.GetRawZeroPoseToStandingAbsoluteTrackingPose();
		return result;
	}
	internal uint GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass,uint [] punTrackedDeviceIndexArray,uint unRelativeToTrackedDeviceIndex)
	{
		uint result = FnTable.GetSortedTrackedDeviceIndicesOfClass(eTrackedDeviceClass,punTrackedDeviceIndexArray,(uint) punTrackedDeviceIndexArray.Length,unRelativeToTrackedDeviceIndex);
		return result;
	}
	internal EDeviceActivityLevel GetTrackedDeviceActivityLevel(uint unDeviceId)
	{
		EDeviceActivityLevel result = FnTable.GetTrackedDeviceActivityLevel(unDeviceId);
		return result;
	}
	internal void ApplyTransform(ref TrackedDevicePose_t pOutputPose,ref TrackedDevicePose_t pTrackedDevicePose,ref HmdMatrix34_t pTransform)
	{
		FnTable.ApplyTransform(ref pOutputPose,ref pTrackedDevicePose,ref pTransform);
	}
	internal uint GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType)
	{
		uint result = FnTable.GetTrackedDeviceIndexForControllerRole(unDeviceType);
		return result;
	}
	internal ETrackedControllerRole GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex)
	{
		ETrackedControllerRole result = FnTable.GetControllerRoleForTrackedDeviceIndex(unDeviceIndex);
		return result;
	}
	internal ETrackedDeviceClass GetTrackedDeviceClass(uint unDeviceIndex)
	{
		ETrackedDeviceClass result = FnTable.GetTrackedDeviceClass(unDeviceIndex);
		return result;
	}
	internal bool IsTrackedDeviceConnected(uint unDeviceIndex)
	{
		bool result = FnTable.IsTrackedDeviceConnected(unDeviceIndex);
		return result;
	}
	internal bool GetBoolTrackedDeviceProperty(uint unDeviceIndex,ETrackedDeviceProperty prop,ref ETrackedPropertyError pError)
	{
		bool result = FnTable.GetBoolTrackedDeviceProperty(unDeviceIndex,prop,ref pError);
		return result;
	}
	internal float GetFloatTrackedDeviceProperty(uint unDeviceIndex,ETrackedDeviceProperty prop,ref ETrackedPropertyError pError)
	{
		float result = FnTable.GetFloatTrackedDeviceProperty(unDeviceIndex,prop,ref pError);
		return result;
	}
	internal int GetInt32TrackedDeviceProperty(uint unDeviceIndex,ETrackedDeviceProperty prop,ref ETrackedPropertyError pError)
	{
		int result = FnTable.GetInt32TrackedDeviceProperty(unDeviceIndex,prop,ref pError);
		return result;
	}
	internal ulong GetUint64TrackedDeviceProperty(uint unDeviceIndex,ETrackedDeviceProperty prop,ref ETrackedPropertyError pError)
	{
		ulong result = FnTable.GetUint64TrackedDeviceProperty(unDeviceIndex,prop,ref pError);
		return result;
	}
	internal HmdMatrix34_t GetMatrix34TrackedDeviceProperty(uint unDeviceIndex,ETrackedDeviceProperty prop,ref ETrackedPropertyError pError)
	{
		HmdMatrix34_t result = FnTable.GetMatrix34TrackedDeviceProperty(unDeviceIndex,prop,ref pError);
		return result;
	}
	internal uint GetStringTrackedDeviceProperty(uint unDeviceIndex,ETrackedDeviceProperty prop,System.Text.StringBuilder pchValue,uint unBufferSize,ref ETrackedPropertyError pError)
	{
		uint result = FnTable.GetStringTrackedDeviceProperty(unDeviceIndex,prop,pchValue,unBufferSize,ref pError);
		return result;
	}
	internal string GetPropErrorNameFromEnum(ETrackedPropertyError error)
	{
		IntPtr result = FnTable.GetPropErrorNameFromEnum(error);
		return Marshal.PtrToStringAnsi(result);
	}
	internal bool PollNextEvent(ref VREvent_t pEvent,uint uncbVREvent)
	{
		bool result = FnTable.PollNextEvent(ref pEvent,uncbVREvent);
		return result;
	}
	internal bool PollNextEventWithPose(ETrackingUniverseOrigin eOrigin,ref VREvent_t pEvent,uint uncbVREvent,ref TrackedDevicePose_t pTrackedDevicePose)
	{
		bool result = FnTable.PollNextEventWithPose(eOrigin,ref pEvent,uncbVREvent,ref pTrackedDevicePose);
		return result;
	}
	internal string GetEventTypeNameFromEnum(EVREventType eType)
	{
		IntPtr result = FnTable.GetEventTypeNameFromEnum(eType);
		return Marshal.PtrToStringAnsi(result);
	}
	internal HiddenAreaMesh_t GetHiddenAreaMesh(EVREye eEye,EHiddenAreaMeshType type)
	{
		HiddenAreaMesh_t result = FnTable.GetHiddenAreaMesh(eEye,type);
		return result;
	}
	internal bool GetControllerState(uint unControllerDeviceIndex,ref VRControllerState_t pControllerState,uint unControllerStateSize)
	{
		bool result = FnTable.GetControllerState(unControllerDeviceIndex,ref pControllerState,unControllerStateSize);
		return result;
	}
	internal bool GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin,uint unControllerDeviceIndex,ref VRControllerState_t pControllerState,uint unControllerStateSize,ref TrackedDevicePose_t pTrackedDevicePose)
	{
		bool result = FnTable.GetControllerStateWithPose(eOrigin,unControllerDeviceIndex,ref pControllerState,unControllerStateSize,ref pTrackedDevicePose);
		return result;
	}
	internal void TriggerHapticPulse(uint unControllerDeviceIndex,uint unAxisId,char usDurationMicroSec)
	{
		FnTable.TriggerHapticPulse(unControllerDeviceIndex,unAxisId,usDurationMicroSec);
	}
	internal string GetButtonIdNameFromEnum(EVRButtonId eButtonId)
	{
		IntPtr result = FnTable.GetButtonIdNameFromEnum(eButtonId);
		return Marshal.PtrToStringAnsi(result);
	}
	internal string GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType)
	{
		IntPtr result = FnTable.GetControllerAxisTypeNameFromEnum(eAxisType);
		return Marshal.PtrToStringAnsi(result);
	}
	internal bool CaptureInputFocus()
	{
		bool result = FnTable.CaptureInputFocus();
		return result;
	}
	internal void ReleaseInputFocus()
	{
		FnTable.ReleaseInputFocus();
	}
	internal bool IsInputFocusCapturedByAnotherProcess()
	{
		bool result = FnTable.IsInputFocusCapturedByAnotherProcess();
		return result;
	}
	internal uint DriverDebugRequest(uint unDeviceIndex,string pchRequest,string pchResponseBuffer,uint unResponseBufferSize)
	{
		uint result = FnTable.DriverDebugRequest(unDeviceIndex,pchRequest,pchResponseBuffer,unResponseBufferSize);
		return result;
	}
	internal EVRFirmwareError PerformFirmwareUpdate(uint unDeviceIndex)
	{
		EVRFirmwareError result = FnTable.PerformFirmwareUpdate(unDeviceIndex);
		return result;
	}
	internal void AcknowledgeQuit_Exiting()
	{
		FnTable.AcknowledgeQuit_Exiting();
	}
	internal void AcknowledgeQuit_UserPrompt()
	{
		FnTable.AcknowledgeQuit_UserPrompt();
	}
}


internal class CVRExtendedDisplay
{
	IVRExtendedDisplay FnTable;
	internal CVRExtendedDisplay(IntPtr pInterface)
	{
		FnTable = (IVRExtendedDisplay)Marshal.PtrToStructure(pInterface, typeof(IVRExtendedDisplay));
	}
	internal void GetWindowBounds(ref int pnX,ref int pnY,ref uint pnWidth,ref uint pnHeight)
	{
		pnX = 0;
		pnY = 0;
		pnWidth = 0;
		pnHeight = 0;
		FnTable.GetWindowBounds(ref pnX,ref pnY,ref pnWidth,ref pnHeight);
	}
	internal void GetEyeOutputViewport(EVREye eEye,ref uint pnX,ref uint pnY,ref uint pnWidth,ref uint pnHeight)
	{
		pnX = 0;
		pnY = 0;
		pnWidth = 0;
		pnHeight = 0;
		FnTable.GetEyeOutputViewport(eEye,ref pnX,ref pnY,ref pnWidth,ref pnHeight);
	}
	internal void GetDXGIOutputInfo(ref int pnAdapterIndex,ref int pnAdapterOutputIndex)
	{
		pnAdapterIndex = 0;
		pnAdapterOutputIndex = 0;
		FnTable.GetDXGIOutputInfo(ref pnAdapterIndex,ref pnAdapterOutputIndex);
	}
}


internal class CVRTrackedCamera
{
	IVRTrackedCamera FnTable;
	internal CVRTrackedCamera(IntPtr pInterface)
	{
		FnTable = (IVRTrackedCamera)Marshal.PtrToStructure(pInterface, typeof(IVRTrackedCamera));
	}
	internal string GetCameraErrorNameFromEnum(EVRTrackedCameraError eCameraError)
	{
		IntPtr result = FnTable.GetCameraErrorNameFromEnum(eCameraError);
		return Marshal.PtrToStringAnsi(result);
	}
	internal EVRTrackedCameraError HasCamera(uint nDeviceIndex,ref bool pHasCamera)
	{
		pHasCamera = false;
		EVRTrackedCameraError result = FnTable.HasCamera(nDeviceIndex,ref pHasCamera);
		return result;
	}
	internal EVRTrackedCameraError GetCameraFrameSize(uint nDeviceIndex,EVRTrackedCameraFrameType eFrameType,ref uint pnWidth,ref uint pnHeight,ref uint pnFrameBufferSize)
	{
		pnWidth = 0;
		pnHeight = 0;
		pnFrameBufferSize = 0;
		EVRTrackedCameraError result = FnTable.GetCameraFrameSize(nDeviceIndex,eFrameType,ref pnWidth,ref pnHeight,ref pnFrameBufferSize);
		return result;
	}
	internal EVRTrackedCameraError GetCameraIntrinisics(uint nDeviceIndex,EVRTrackedCameraFrameType eFrameType,ref HmdVector2_t pFocalLength,ref HmdVector2_t pCenter)
	{
		EVRTrackedCameraError result = FnTable.GetCameraIntrinisics(nDeviceIndex,eFrameType,ref pFocalLength,ref pCenter);
		return result;
	}
	internal EVRTrackedCameraError GetCameraProjection(uint nDeviceIndex,EVRTrackedCameraFrameType eFrameType,float flZNear,float flZFar,ref HmdMatrix44_t pProjection)
	{
		EVRTrackedCameraError result = FnTable.GetCameraProjection(nDeviceIndex,eFrameType,flZNear,flZFar,ref pProjection);
		return result;
	}
	internal EVRTrackedCameraError AcquireVideoStreamingService(uint nDeviceIndex,ref ulong pHandle)
	{
		pHandle = 0;
		EVRTrackedCameraError result = FnTable.AcquireVideoStreamingService(nDeviceIndex,ref pHandle);
		return result;
	}
	internal EVRTrackedCameraError ReleaseVideoStreamingService(ulong hTrackedCamera)
	{
		EVRTrackedCameraError result = FnTable.ReleaseVideoStreamingService(hTrackedCamera);
		return result;
	}
	internal EVRTrackedCameraError GetVideoStreamFrameBuffer(ulong hTrackedCamera,EVRTrackedCameraFrameType eFrameType,IntPtr pFrameBuffer,uint nFrameBufferSize,ref CameraVideoStreamFrameHeader_t pFrameHeader,uint nFrameHeaderSize)
	{
		EVRTrackedCameraError result = FnTable.GetVideoStreamFrameBuffer(hTrackedCamera,eFrameType,pFrameBuffer,nFrameBufferSize,ref pFrameHeader,nFrameHeaderSize);
		return result;
	}
	internal EVRTrackedCameraError GetVideoStreamTextureSize(uint nDeviceIndex,EVRTrackedCameraFrameType eFrameType,ref VRTextureBounds_t pTextureBounds,ref uint pnWidth,ref uint pnHeight)
	{
		pnWidth = 0;
		pnHeight = 0;
		EVRTrackedCameraError result = FnTable.GetVideoStreamTextureSize(nDeviceIndex,eFrameType,ref pTextureBounds,ref pnWidth,ref pnHeight);
		return result;
	}
	internal EVRTrackedCameraError GetVideoStreamTextureD3D11(ulong hTrackedCamera,EVRTrackedCameraFrameType eFrameType,IntPtr pD3D11DeviceOrResource,ref IntPtr ppD3D11ShaderResourceView,ref CameraVideoStreamFrameHeader_t pFrameHeader,uint nFrameHeaderSize)
	{
		EVRTrackedCameraError result = FnTable.GetVideoStreamTextureD3D11(hTrackedCamera,eFrameType,pD3D11DeviceOrResource,ref ppD3D11ShaderResourceView,ref pFrameHeader,nFrameHeaderSize);
		return result;
	}
	internal EVRTrackedCameraError GetVideoStreamTextureGL(ulong hTrackedCamera,EVRTrackedCameraFrameType eFrameType,ref uint pglTextureId,ref CameraVideoStreamFrameHeader_t pFrameHeader,uint nFrameHeaderSize)
	{
		pglTextureId = 0;
		EVRTrackedCameraError result = FnTable.GetVideoStreamTextureGL(hTrackedCamera,eFrameType,ref pglTextureId,ref pFrameHeader,nFrameHeaderSize);
		return result;
	}
	internal EVRTrackedCameraError ReleaseVideoStreamTextureGL(ulong hTrackedCamera,uint glTextureId)
	{
		EVRTrackedCameraError result = FnTable.ReleaseVideoStreamTextureGL(hTrackedCamera,glTextureId);
		return result;
	}
}


internal class CVRApplications
{
	IVRApplications FnTable;
	internal CVRApplications(IntPtr pInterface)
	{
		FnTable = (IVRApplications)Marshal.PtrToStructure(pInterface, typeof(IVRApplications));
	}
	internal EVRApplicationError AddApplicationManifest(string pchApplicationManifestFullPath,bool bTemporary)
	{
		EVRApplicationError result = FnTable.AddApplicationManifest(pchApplicationManifestFullPath,bTemporary);
		return result;
	}
	internal EVRApplicationError RemoveApplicationManifest(string pchApplicationManifestFullPath)
	{
		EVRApplicationError result = FnTable.RemoveApplicationManifest(pchApplicationManifestFullPath);
		return result;
	}
	internal bool IsApplicationInstalled(string pchAppKey)
	{
		bool result = FnTable.IsApplicationInstalled(pchAppKey);
		return result;
	}
	internal uint GetApplicationCount()
	{
		uint result = FnTable.GetApplicationCount();
		return result;
	}
	internal EVRApplicationError GetApplicationKeyByIndex(uint unApplicationIndex,System.Text.StringBuilder pchAppKeyBuffer,uint unAppKeyBufferLen)
	{
		EVRApplicationError result = FnTable.GetApplicationKeyByIndex(unApplicationIndex,pchAppKeyBuffer,unAppKeyBufferLen);
		return result;
	}
	internal EVRApplicationError GetApplicationKeyByProcessId(uint unProcessId,string pchAppKeyBuffer,uint unAppKeyBufferLen)
	{
		EVRApplicationError result = FnTable.GetApplicationKeyByProcessId(unProcessId,pchAppKeyBuffer,unAppKeyBufferLen);
		return result;
	}
	internal EVRApplicationError LaunchApplication(string pchAppKey)
	{
		EVRApplicationError result = FnTable.LaunchApplication(pchAppKey);
		return result;
	}
	internal EVRApplicationError LaunchTemplateApplication(string pchTemplateAppKey,string pchNewAppKey,AppOverrideKeys_t [] pKeys)
	{
		EVRApplicationError result = FnTable.LaunchTemplateApplication(pchTemplateAppKey,pchNewAppKey,pKeys,(uint) pKeys.Length);
		return result;
	}
	internal EVRApplicationError LaunchApplicationFromMimeType(string pchMimeType,string pchArgs)
	{
		EVRApplicationError result = FnTable.LaunchApplicationFromMimeType(pchMimeType,pchArgs);
		return result;
	}
	internal EVRApplicationError LaunchDashboardOverlay(string pchAppKey)
	{
		EVRApplicationError result = FnTable.LaunchDashboardOverlay(pchAppKey);
		return result;
	}
	internal bool CancelApplicationLaunch(string pchAppKey)
	{
		bool result = FnTable.CancelApplicationLaunch(pchAppKey);
		return result;
	}
	internal EVRApplicationError IdentifyApplication(uint unProcessId,string pchAppKey)
	{
		EVRApplicationError result = FnTable.IdentifyApplication(unProcessId,pchAppKey);
		return result;
	}
	internal uint GetApplicationProcessId(string pchAppKey)
	{
		uint result = FnTable.GetApplicationProcessId(pchAppKey);
		return result;
	}
	internal string GetApplicationsErrorNameFromEnum(EVRApplicationError error)
	{
		IntPtr result = FnTable.GetApplicationsErrorNameFromEnum(error);
		return Marshal.PtrToStringAnsi(result);
	}
	internal uint GetApplicationPropertyString(string pchAppKey,EVRApplicationProperty eProperty,System.Text.StringBuilder pchPropertyValueBuffer,uint unPropertyValueBufferLen,ref EVRApplicationError peError)
	{
		uint result = FnTable.GetApplicationPropertyString(pchAppKey,eProperty,pchPropertyValueBuffer,unPropertyValueBufferLen,ref peError);
		return result;
	}
	internal bool GetApplicationPropertyBool(string pchAppKey,EVRApplicationProperty eProperty,ref EVRApplicationError peError)
	{
		bool result = FnTable.GetApplicationPropertyBool(pchAppKey,eProperty,ref peError);
		return result;
	}
	internal ulong GetApplicationPropertyUint64(string pchAppKey,EVRApplicationProperty eProperty,ref EVRApplicationError peError)
	{
		ulong result = FnTable.GetApplicationPropertyUint64(pchAppKey,eProperty,ref peError);
		return result;
	}
	internal EVRApplicationError SetApplicationAutoLaunch(string pchAppKey,bool bAutoLaunch)
	{
		EVRApplicationError result = FnTable.SetApplicationAutoLaunch(pchAppKey,bAutoLaunch);
		return result;
	}
	internal bool GetApplicationAutoLaunch(string pchAppKey)
	{
		bool result = FnTable.GetApplicationAutoLaunch(pchAppKey);
		return result;
	}
	internal EVRApplicationError SetDefaultApplicationForMimeType(string pchAppKey,string pchMimeType)
	{
		EVRApplicationError result = FnTable.SetDefaultApplicationForMimeType(pchAppKey,pchMimeType);
		return result;
	}
	internal bool GetDefaultApplicationForMimeType(string pchMimeType,string pchAppKeyBuffer,uint unAppKeyBufferLen)
	{
		bool result = FnTable.GetDefaultApplicationForMimeType(pchMimeType,pchAppKeyBuffer,unAppKeyBufferLen);
		return result;
	}
	internal bool GetApplicationSupportedMimeTypes(string pchAppKey,string pchMimeTypesBuffer,uint unMimeTypesBuffer)
	{
		bool result = FnTable.GetApplicationSupportedMimeTypes(pchAppKey,pchMimeTypesBuffer,unMimeTypesBuffer);
		return result;
	}
	internal uint GetApplicationsThatSupportMimeType(string pchMimeType,string pchAppKeysThatSupportBuffer,uint unAppKeysThatSupportBuffer)
	{
		uint result = FnTable.GetApplicationsThatSupportMimeType(pchMimeType,pchAppKeysThatSupportBuffer,unAppKeysThatSupportBuffer);
		return result;
	}
	internal uint GetApplicationLaunchArguments(uint unHandle,string pchArgs,uint unArgs)
	{
		uint result = FnTable.GetApplicationLaunchArguments(unHandle,pchArgs,unArgs);
		return result;
	}
	internal EVRApplicationError GetStartingApplication(string pchAppKeyBuffer,uint unAppKeyBufferLen)
	{
		EVRApplicationError result = FnTable.GetStartingApplication(pchAppKeyBuffer,unAppKeyBufferLen);
		return result;
	}
	internal EVRApplicationTransitionState GetTransitionState()
	{
		EVRApplicationTransitionState result = FnTable.GetTransitionState();
		return result;
	}
	internal EVRApplicationError PerformApplicationPrelaunchCheck(string pchAppKey)
	{
		EVRApplicationError result = FnTable.PerformApplicationPrelaunchCheck(pchAppKey);
		return result;
	}
	internal string GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state)
	{
		IntPtr result = FnTable.GetApplicationsTransitionStateNameFromEnum(state);
		return Marshal.PtrToStringAnsi(result);
	}
	internal bool IsQuitUserPromptRequested()
	{
		bool result = FnTable.IsQuitUserPromptRequested();
		return result;
	}
	internal EVRApplicationError LaunchInternalProcess(string pchBinaryPath,string pchArguments,string pchWorkingDirectory)
	{
		EVRApplicationError result = FnTable.LaunchInternalProcess(pchBinaryPath,pchArguments,pchWorkingDirectory);
		return result;
	}
}


internal class CVRChaperone
{
	IVRChaperone FnTable;
	internal CVRChaperone(IntPtr pInterface)
	{
		FnTable = (IVRChaperone)Marshal.PtrToStructure(pInterface, typeof(IVRChaperone));
	}
	internal ChaperoneCalibrationState GetCalibrationState()
	{
		ChaperoneCalibrationState result = FnTable.GetCalibrationState();
		return result;
	}
	internal bool GetPlayAreaSize(ref float pSizeX,ref float pSizeZ)
	{
		pSizeX = 0;
		pSizeZ = 0;
		bool result = FnTable.GetPlayAreaSize(ref pSizeX,ref pSizeZ);
		return result;
	}
	internal bool GetPlayAreaRect(ref HmdQuad_t rect)
	{
		bool result = FnTable.GetPlayAreaRect(ref rect);
		return result;
	}
	internal void ReloadInfo()
	{
		FnTable.ReloadInfo();
	}
	internal void SetSceneColor(HmdColor_t color)
	{
		FnTable.SetSceneColor(color);
	}
	internal void GetBoundsColor(ref HmdColor_t pOutputColorArray,int nNumOutputColors,float flCollisionBoundsFadeDistance,ref HmdColor_t pOutputCameraColor)
	{
		FnTable.GetBoundsColor(ref pOutputColorArray,nNumOutputColors,flCollisionBoundsFadeDistance,ref pOutputCameraColor);
	}
	internal bool AreBoundsVisible()
	{
		bool result = FnTable.AreBoundsVisible();
		return result;
	}
	internal void ForceBoundsVisible(bool bForce)
	{
		FnTable.ForceBoundsVisible(bForce);
	}
}


internal class CVRChaperoneSetup
{
	IVRChaperoneSetup FnTable;
	internal CVRChaperoneSetup(IntPtr pInterface)
	{
		FnTable = (IVRChaperoneSetup)Marshal.PtrToStructure(pInterface, typeof(IVRChaperoneSetup));
	}
	internal bool CommitWorkingCopy(EChaperoneConfigFile configFile)
	{
		bool result = FnTable.CommitWorkingCopy(configFile);
		return result;
	}
	internal void RevertWorkingCopy()
	{
		FnTable.RevertWorkingCopy();
	}
	internal bool GetWorkingPlayAreaSize(ref float pSizeX,ref float pSizeZ)
	{
		pSizeX = 0;
		pSizeZ = 0;
		bool result = FnTable.GetWorkingPlayAreaSize(ref pSizeX,ref pSizeZ);
		return result;
	}
	internal bool GetWorkingPlayAreaRect(ref HmdQuad_t rect)
	{
		bool result = FnTable.GetWorkingPlayAreaRect(ref rect);
		return result;
	}
	internal bool GetWorkingCollisionBoundsInfo(out HmdQuad_t [] pQuadsBuffer)
	{
		uint punQuadsCount = 0;
		bool result = FnTable.GetWorkingCollisionBoundsInfo(null,ref punQuadsCount);
		pQuadsBuffer= new HmdQuad_t[punQuadsCount];
		result = FnTable.GetWorkingCollisionBoundsInfo(pQuadsBuffer,ref punQuadsCount);
		return result;
	}
	internal bool GetLiveCollisionBoundsInfo(out HmdQuad_t [] pQuadsBuffer)
	{
		uint punQuadsCount = 0;
		bool result = FnTable.GetLiveCollisionBoundsInfo(null,ref punQuadsCount);
		pQuadsBuffer= new HmdQuad_t[punQuadsCount];
		result = FnTable.GetLiveCollisionBoundsInfo(pQuadsBuffer,ref punQuadsCount);
		return result;
	}
	internal bool GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
	{
		bool result = FnTable.GetWorkingSeatedZeroPoseToRawTrackingPose(ref pmatSeatedZeroPoseToRawTrackingPose);
		return result;
	}
	internal bool GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose)
	{
		bool result = FnTable.GetWorkingStandingZeroPoseToRawTrackingPose(ref pmatStandingZeroPoseToRawTrackingPose);
		return result;
	}
	internal void SetWorkingPlayAreaSize(float sizeX,float sizeZ)
	{
		FnTable.SetWorkingPlayAreaSize(sizeX,sizeZ);
	}
	internal void SetWorkingCollisionBoundsInfo(HmdQuad_t [] pQuadsBuffer)
	{
		FnTable.SetWorkingCollisionBoundsInfo(pQuadsBuffer,(uint) pQuadsBuffer.Length);
	}
	internal void SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose)
	{
		FnTable.SetWorkingSeatedZeroPoseToRawTrackingPose(ref pMatSeatedZeroPoseToRawTrackingPose);
	}
	internal void SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose)
	{
		FnTable.SetWorkingStandingZeroPoseToRawTrackingPose(ref pMatStandingZeroPoseToRawTrackingPose);
	}
	internal void ReloadFromDisk(EChaperoneConfigFile configFile)
	{
		FnTable.ReloadFromDisk(configFile);
	}
	internal bool GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
	{
		bool result = FnTable.GetLiveSeatedZeroPoseToRawTrackingPose(ref pmatSeatedZeroPoseToRawTrackingPose);
		return result;
	}
	internal void SetWorkingCollisionBoundsTagsInfo(byte [] pTagsBuffer)
	{
		FnTable.SetWorkingCollisionBoundsTagsInfo(pTagsBuffer,(uint) pTagsBuffer.Length);
	}
	internal bool GetLiveCollisionBoundsTagsInfo(out byte [] pTagsBuffer)
	{
		uint punTagCount = 0;
		bool result = FnTable.GetLiveCollisionBoundsTagsInfo(null,ref punTagCount);
		pTagsBuffer= new byte[punTagCount];
		result = FnTable.GetLiveCollisionBoundsTagsInfo(pTagsBuffer,ref punTagCount);
		return result;
	}
	internal bool SetWorkingPhysicalBoundsInfo(HmdQuad_t [] pQuadsBuffer)
	{
		bool result = FnTable.SetWorkingPhysicalBoundsInfo(pQuadsBuffer,(uint) pQuadsBuffer.Length);
		return result;
	}
	internal bool GetLivePhysicalBoundsInfo(out HmdQuad_t [] pQuadsBuffer)
	{
		uint punQuadsCount = 0;
		bool result = FnTable.GetLivePhysicalBoundsInfo(null,ref punQuadsCount);
		pQuadsBuffer= new HmdQuad_t[punQuadsCount];
		result = FnTable.GetLivePhysicalBoundsInfo(pQuadsBuffer,ref punQuadsCount);
		return result;
	}
	internal bool ExportLiveToBuffer(System.Text.StringBuilder pBuffer,ref uint pnBufferLength)
	{
		pnBufferLength = 0;
		bool result = FnTable.ExportLiveToBuffer(pBuffer,ref pnBufferLength);
		return result;
	}
	internal bool ImportFromBufferToWorking(string pBuffer,uint nImportFlags)
	{
		bool result = FnTable.ImportFromBufferToWorking(pBuffer,nImportFlags);
		return result;
	}
}


internal class CVRCompositor
{
	IVRCompositor FnTable;
	internal CVRCompositor(IntPtr pInterface)
	{
		FnTable = (IVRCompositor)Marshal.PtrToStructure(pInterface, typeof(IVRCompositor));
	}
	internal void SetTrackingSpace(ETrackingUniverseOrigin eOrigin)
	{
		FnTable.SetTrackingSpace(eOrigin);
	}
	internal ETrackingUniverseOrigin GetTrackingSpace()
	{
		ETrackingUniverseOrigin result = FnTable.GetTrackingSpace();
		return result;
	}
	internal EVRCompositorError WaitGetPoses(TrackedDevicePose_t [] pRenderPoseArray,TrackedDevicePose_t [] pGamePoseArray)
	{
		EVRCompositorError result = FnTable.WaitGetPoses(pRenderPoseArray,(uint) pRenderPoseArray.Length,pGamePoseArray,(uint) pGamePoseArray.Length);
		return result;
	}
	internal EVRCompositorError GetLastPoses(TrackedDevicePose_t [] pRenderPoseArray,TrackedDevicePose_t [] pGamePoseArray)
	{
		EVRCompositorError result = FnTable.GetLastPoses(pRenderPoseArray,(uint) pRenderPoseArray.Length,pGamePoseArray,(uint) pGamePoseArray.Length);
		return result;
	}
	internal EVRCompositorError GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex,ref TrackedDevicePose_t pOutputPose,ref TrackedDevicePose_t pOutputGamePose)
	{
		EVRCompositorError result = FnTable.GetLastPoseForTrackedDeviceIndex(unDeviceIndex,ref pOutputPose,ref pOutputGamePose);
		return result;
	}
	internal EVRCompositorError Submit(EVREye eEye,ref Texture_t pTexture,ref VRTextureBounds_t pBounds,EVRSubmitFlags nSubmitFlags)
	{
		EVRCompositorError result = FnTable.Submit(eEye,ref pTexture,ref pBounds,nSubmitFlags);
		return result;
	}
	internal void ClearLastSubmittedFrame()
	{
		FnTable.ClearLastSubmittedFrame();
	}
	internal void PostPresentHandoff()
	{
		FnTable.PostPresentHandoff();
	}
	internal bool GetFrameTiming(ref Compositor_FrameTiming pTiming,uint unFramesAgo)
	{
		bool result = FnTable.GetFrameTiming(ref pTiming,unFramesAgo);
		return result;
	}
	internal uint GetFrameTimings(ref Compositor_FrameTiming pTiming,uint nFrames)
	{
		uint result = FnTable.GetFrameTimings(ref pTiming,nFrames);
		return result;
	}
	internal float GetFrameTimeRemaining()
	{
		float result = FnTable.GetFrameTimeRemaining();
		return result;
	}
	internal void GetCumulativeStats(ref Compositor_CumulativeStats pStats,uint nStatsSizeInBytes)
	{
		FnTable.GetCumulativeStats(ref pStats,nStatsSizeInBytes);
	}
	internal void FadeToColor(float fSeconds,float fRed,float fGreen,float fBlue,float fAlpha,bool bBackground)
	{
		FnTable.FadeToColor(fSeconds,fRed,fGreen,fBlue,fAlpha,bBackground);
	}
	internal HmdColor_t GetCurrentFadeColor(bool bBackground)
	{
		HmdColor_t result = FnTable.GetCurrentFadeColor(bBackground);
		return result;
	}
	internal void FadeGrid(float fSeconds,bool bFadeIn)
	{
		FnTable.FadeGrid(fSeconds,bFadeIn);
	}
	internal float GetCurrentGridAlpha()
	{
		float result = FnTable.GetCurrentGridAlpha();
		return result;
	}
	internal EVRCompositorError SetSkyboxOverride(Texture_t [] pTextures)
	{
		EVRCompositorError result = FnTable.SetSkyboxOverride(pTextures,(uint) pTextures.Length);
		return result;
	}
	internal void ClearSkyboxOverride()
	{
		FnTable.ClearSkyboxOverride();
	}
	internal void CompositorBringToFront()
	{
		FnTable.CompositorBringToFront();
	}
	internal void CompositorGoToBack()
	{
		FnTable.CompositorGoToBack();
	}
	internal void CompositorQuit()
	{
		FnTable.CompositorQuit();
	}
	internal bool IsFullscreen()
	{
		bool result = FnTable.IsFullscreen();
		return result;
	}
	internal uint GetCurrentSceneFocusProcess()
	{
		uint result = FnTable.GetCurrentSceneFocusProcess();
		return result;
	}
	internal uint GetLastFrameRenderer()
	{
		uint result = FnTable.GetLastFrameRenderer();
		return result;
	}
	internal bool CanRenderScene()
	{
		bool result = FnTable.CanRenderScene();
		return result;
	}
	internal void ShowMirrorWindow()
	{
		FnTable.ShowMirrorWindow();
	}
	internal void HideMirrorWindow()
	{
		FnTable.HideMirrorWindow();
	}
	internal bool IsMirrorWindowVisible()
	{
		bool result = FnTable.IsMirrorWindowVisible();
		return result;
	}
	internal void CompositorDumpImages()
	{
		FnTable.CompositorDumpImages();
	}
	internal bool ShouldAppRenderWithLowResources()
	{
		bool result = FnTable.ShouldAppRenderWithLowResources();
		return result;
	}
	internal void ForceInterleavedReprojectionOn(bool bOverride)
	{
		FnTable.ForceInterleavedReprojectionOn(bOverride);
	}
	internal void ForceReconnectProcess()
	{
		FnTable.ForceReconnectProcess();
	}
	internal void SuspendRendering(bool bSuspend)
	{
		FnTable.SuspendRendering(bSuspend);
	}
	internal EVRCompositorError GetMirrorTextureD3D11(EVREye eEye,IntPtr pD3D11DeviceOrResource,ref IntPtr ppD3D11ShaderResourceView)
	{
		EVRCompositorError result = FnTable.GetMirrorTextureD3D11(eEye,pD3D11DeviceOrResource,ref ppD3D11ShaderResourceView);
		return result;
	}
	internal EVRCompositorError GetMirrorTextureGL(EVREye eEye,ref uint pglTextureId,IntPtr pglSharedTextureHandle)
	{
		pglTextureId = 0;
		EVRCompositorError result = FnTable.GetMirrorTextureGL(eEye,ref pglTextureId,pglSharedTextureHandle);
		return result;
	}
	internal bool ReleaseSharedGLTexture(uint glTextureId,IntPtr glSharedTextureHandle)
	{
		bool result = FnTable.ReleaseSharedGLTexture(glTextureId,glSharedTextureHandle);
		return result;
	}
	internal void LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle)
	{
		FnTable.LockGLSharedTextureForAccess(glSharedTextureHandle);
	}
	internal void UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle)
	{
		FnTable.UnlockGLSharedTextureForAccess(glSharedTextureHandle);
	}
}


internal class CVROverlay
{
	IVROverlay FnTable;
	internal CVROverlay(IntPtr pInterface)
	{
		FnTable = (IVROverlay)Marshal.PtrToStructure(pInterface, typeof(IVROverlay));
	}
	internal EVROverlayError FindOverlay(string pchOverlayKey,ref ulong pOverlayHandle)
	{
		pOverlayHandle = 0;
		EVROverlayError result = FnTable.FindOverlay(pchOverlayKey,ref pOverlayHandle);
		return result;
	}
	internal EVROverlayError CreateOverlay(string pchOverlayKey,string pchOverlayFriendlyName,ref ulong pOverlayHandle)
	{
		pOverlayHandle = 0;
		EVROverlayError result = FnTable.CreateOverlay(pchOverlayKey,pchOverlayFriendlyName,ref pOverlayHandle);
		return result;
	}
	internal EVROverlayError DestroyOverlay(ulong ulOverlayHandle)
	{
		EVROverlayError result = FnTable.DestroyOverlay(ulOverlayHandle);
		return result;
	}
	internal EVROverlayError SetHighQualityOverlay(ulong ulOverlayHandle)
	{
		EVROverlayError result = FnTable.SetHighQualityOverlay(ulOverlayHandle);
		return result;
	}
	internal ulong GetHighQualityOverlay()
	{
		ulong result = FnTable.GetHighQualityOverlay();
		return result;
	}
	internal uint GetOverlayKey(ulong ulOverlayHandle,System.Text.StringBuilder pchValue,uint unBufferSize,ref EVROverlayError pError)
	{
		uint result = FnTable.GetOverlayKey(ulOverlayHandle,pchValue,unBufferSize,ref pError);
		return result;
	}
	internal uint GetOverlayName(ulong ulOverlayHandle,System.Text.StringBuilder pchValue,uint unBufferSize,ref EVROverlayError pError)
	{
		uint result = FnTable.GetOverlayName(ulOverlayHandle,pchValue,unBufferSize,ref pError);
		return result;
	}
	internal EVROverlayError GetOverlayImageData(ulong ulOverlayHandle,IntPtr pvBuffer,uint unBufferSize,ref uint punWidth,ref uint punHeight)
	{
		punWidth = 0;
		punHeight = 0;
		EVROverlayError result = FnTable.GetOverlayImageData(ulOverlayHandle,pvBuffer,unBufferSize,ref punWidth,ref punHeight);
		return result;
	}
	internal string GetOverlayErrorNameFromEnum(EVROverlayError error)
	{
		IntPtr result = FnTable.GetOverlayErrorNameFromEnum(error);
		return Marshal.PtrToStringAnsi(result);
	}
	internal EVROverlayError SetOverlayRenderingPid(ulong ulOverlayHandle,uint unPID)
	{
		EVROverlayError result = FnTable.SetOverlayRenderingPid(ulOverlayHandle,unPID);
		return result;
	}
	internal uint GetOverlayRenderingPid(ulong ulOverlayHandle)
	{
		uint result = FnTable.GetOverlayRenderingPid(ulOverlayHandle);
		return result;
	}
	internal EVROverlayError SetOverlayFlag(ulong ulOverlayHandle,VROverlayFlags eOverlayFlag,bool bEnabled)
	{
		EVROverlayError result = FnTable.SetOverlayFlag(ulOverlayHandle,eOverlayFlag,bEnabled);
		return result;
	}
	internal EVROverlayError GetOverlayFlag(ulong ulOverlayHandle,VROverlayFlags eOverlayFlag,ref bool pbEnabled)
	{
		pbEnabled = false;
		EVROverlayError result = FnTable.GetOverlayFlag(ulOverlayHandle,eOverlayFlag,ref pbEnabled);
		return result;
	}
	internal EVROverlayError SetOverlayColor(ulong ulOverlayHandle,float fRed,float fGreen,float fBlue)
	{
		EVROverlayError result = FnTable.SetOverlayColor(ulOverlayHandle,fRed,fGreen,fBlue);
		return result;
	}
	internal EVROverlayError GetOverlayColor(ulong ulOverlayHandle,ref float pfRed,ref float pfGreen,ref float pfBlue)
	{
		pfRed = 0;
		pfGreen = 0;
		pfBlue = 0;
		EVROverlayError result = FnTable.GetOverlayColor(ulOverlayHandle,ref pfRed,ref pfGreen,ref pfBlue);
		return result;
	}
	internal EVROverlayError SetOverlayAlpha(ulong ulOverlayHandle,float fAlpha)
	{
		EVROverlayError result = FnTable.SetOverlayAlpha(ulOverlayHandle,fAlpha);
		return result;
	}
	internal EVROverlayError GetOverlayAlpha(ulong ulOverlayHandle,ref float pfAlpha)
	{
		pfAlpha = 0;
		EVROverlayError result = FnTable.GetOverlayAlpha(ulOverlayHandle,ref pfAlpha);
		return result;
	}
	internal EVROverlayError SetOverlayTexelAspect(ulong ulOverlayHandle,float fTexelAspect)
	{
		EVROverlayError result = FnTable.SetOverlayTexelAspect(ulOverlayHandle,fTexelAspect);
		return result;
	}
	internal EVROverlayError GetOverlayTexelAspect(ulong ulOverlayHandle,ref float pfTexelAspect)
	{
		pfTexelAspect = 0;
		EVROverlayError result = FnTable.GetOverlayTexelAspect(ulOverlayHandle,ref pfTexelAspect);
		return result;
	}
	internal EVROverlayError SetOverlaySortOrder(ulong ulOverlayHandle,uint unSortOrder)
	{
		EVROverlayError result = FnTable.SetOverlaySortOrder(ulOverlayHandle,unSortOrder);
		return result;
	}
	internal EVROverlayError GetOverlaySortOrder(ulong ulOverlayHandle,ref uint punSortOrder)
	{
		punSortOrder = 0;
		EVROverlayError result = FnTable.GetOverlaySortOrder(ulOverlayHandle,ref punSortOrder);
		return result;
	}
	internal EVROverlayError SetOverlayWidthInMeters(ulong ulOverlayHandle,float fWidthInMeters)
	{
		EVROverlayError result = FnTable.SetOverlayWidthInMeters(ulOverlayHandle,fWidthInMeters);
		return result;
	}
	internal EVROverlayError GetOverlayWidthInMeters(ulong ulOverlayHandle,ref float pfWidthInMeters)
	{
		pfWidthInMeters = 0;
		EVROverlayError result = FnTable.GetOverlayWidthInMeters(ulOverlayHandle,ref pfWidthInMeters);
		return result;
	}
	internal EVROverlayError SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle,float fMinDistanceInMeters,float fMaxDistanceInMeters)
	{
		EVROverlayError result = FnTable.SetOverlayAutoCurveDistanceRangeInMeters(ulOverlayHandle,fMinDistanceInMeters,fMaxDistanceInMeters);
		return result;
	}
	internal EVROverlayError GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle,ref float pfMinDistanceInMeters,ref float pfMaxDistanceInMeters)
	{
		pfMinDistanceInMeters = 0;
		pfMaxDistanceInMeters = 0;
		EVROverlayError result = FnTable.GetOverlayAutoCurveDistanceRangeInMeters(ulOverlayHandle,ref pfMinDistanceInMeters,ref pfMaxDistanceInMeters);
		return result;
	}
	internal EVROverlayError SetOverlayTextureColorSpace(ulong ulOverlayHandle,EColorSpace eTextureColorSpace)
	{
		EVROverlayError result = FnTable.SetOverlayTextureColorSpace(ulOverlayHandle,eTextureColorSpace);
		return result;
	}
	internal EVROverlayError GetOverlayTextureColorSpace(ulong ulOverlayHandle,ref EColorSpace peTextureColorSpace)
	{
		EVROverlayError result = FnTable.GetOverlayTextureColorSpace(ulOverlayHandle,ref peTextureColorSpace);
		return result;
	}
	internal EVROverlayError SetOverlayTextureBounds(ulong ulOverlayHandle,ref VRTextureBounds_t pOverlayTextureBounds)
	{
		EVROverlayError result = FnTable.SetOverlayTextureBounds(ulOverlayHandle,ref pOverlayTextureBounds);
		return result;
	}
	internal EVROverlayError GetOverlayTextureBounds(ulong ulOverlayHandle,ref VRTextureBounds_t pOverlayTextureBounds)
	{
		EVROverlayError result = FnTable.GetOverlayTextureBounds(ulOverlayHandle,ref pOverlayTextureBounds);
		return result;
	}
	internal EVROverlayError GetOverlayTransformType(ulong ulOverlayHandle,ref VROverlayTransformType peTransformType)
	{
		EVROverlayError result = FnTable.GetOverlayTransformType(ulOverlayHandle,ref peTransformType);
		return result;
	}
	internal EVROverlayError SetOverlayTransformAbsolute(ulong ulOverlayHandle,ETrackingUniverseOrigin eTrackingOrigin,ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform)
	{
		EVROverlayError result = FnTable.SetOverlayTransformAbsolute(ulOverlayHandle,eTrackingOrigin,ref pmatTrackingOriginToOverlayTransform);
		return result;
	}
	internal EVROverlayError GetOverlayTransformAbsolute(ulong ulOverlayHandle,ref ETrackingUniverseOrigin peTrackingOrigin,ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform)
	{
		EVROverlayError result = FnTable.GetOverlayTransformAbsolute(ulOverlayHandle,ref peTrackingOrigin,ref pmatTrackingOriginToOverlayTransform);
		return result;
	}
	internal EVROverlayError SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle,uint unTrackedDevice,ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform)
	{
		EVROverlayError result = FnTable.SetOverlayTransformTrackedDeviceRelative(ulOverlayHandle,unTrackedDevice,ref pmatTrackedDeviceToOverlayTransform);
		return result;
	}
	internal EVROverlayError GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle,ref uint punTrackedDevice,ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform)
	{
		punTrackedDevice = 0;
		EVROverlayError result = FnTable.GetOverlayTransformTrackedDeviceRelative(ulOverlayHandle,ref punTrackedDevice,ref pmatTrackedDeviceToOverlayTransform);
		return result;
	}
	internal EVROverlayError SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle,uint unDeviceIndex,string pchComponentName)
	{
		EVROverlayError result = FnTable.SetOverlayTransformTrackedDeviceComponent(ulOverlayHandle,unDeviceIndex,pchComponentName);
		return result;
	}
	internal EVROverlayError GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle,ref uint punDeviceIndex,string pchComponentName,uint unComponentNameSize)
	{
		punDeviceIndex = 0;
		EVROverlayError result = FnTable.GetOverlayTransformTrackedDeviceComponent(ulOverlayHandle,ref punDeviceIndex,pchComponentName,unComponentNameSize);
		return result;
	}
	internal EVROverlayError ShowOverlay(ulong ulOverlayHandle)
	{
		EVROverlayError result = FnTable.ShowOverlay(ulOverlayHandle);
		return result;
	}
	internal EVROverlayError HideOverlay(ulong ulOverlayHandle)
	{
		EVROverlayError result = FnTable.HideOverlay(ulOverlayHandle);
		return result;
	}
	internal bool IsOverlayVisible(ulong ulOverlayHandle)
	{
		bool result = FnTable.IsOverlayVisible(ulOverlayHandle);
		return result;
	}
	internal EVROverlayError GetTransformForOverlayCoordinates(ulong ulOverlayHandle,ETrackingUniverseOrigin eTrackingOrigin,HmdVector2_t coordinatesInOverlay,ref HmdMatrix34_t pmatTransform)
	{
		EVROverlayError result = FnTable.GetTransformForOverlayCoordinates(ulOverlayHandle,eTrackingOrigin,coordinatesInOverlay,ref pmatTransform);
		return result;
	}
	internal bool PollNextOverlayEvent(ulong ulOverlayHandle,ref VREvent_t pEvent,uint uncbVREvent)
	{
		bool result = FnTable.PollNextOverlayEvent(ulOverlayHandle,ref pEvent,uncbVREvent);
		return result;
	}
	internal EVROverlayError GetOverlayInputMethod(ulong ulOverlayHandle,ref VROverlayInputMethod peInputMethod)
	{
		EVROverlayError result = FnTable.GetOverlayInputMethod(ulOverlayHandle,ref peInputMethod);
		return result;
	}
	internal EVROverlayError SetOverlayInputMethod(ulong ulOverlayHandle,VROverlayInputMethod eInputMethod)
	{
		EVROverlayError result = FnTable.SetOverlayInputMethod(ulOverlayHandle,eInputMethod);
		return result;
	}
	internal EVROverlayError GetOverlayMouseScale(ulong ulOverlayHandle,ref HmdVector2_t pvecMouseScale)
	{
		EVROverlayError result = FnTable.GetOverlayMouseScale(ulOverlayHandle,ref pvecMouseScale);
		return result;
	}
	internal EVROverlayError SetOverlayMouseScale(ulong ulOverlayHandle,ref HmdVector2_t pvecMouseScale)
	{
		EVROverlayError result = FnTable.SetOverlayMouseScale(ulOverlayHandle,ref pvecMouseScale);
		return result;
	}
	internal bool ComputeOverlayIntersection(ulong ulOverlayHandle,ref VROverlayIntersectionParams_t pParams,ref VROverlayIntersectionResults_t pResults)
	{
		bool result = FnTable.ComputeOverlayIntersection(ulOverlayHandle,ref pParams,ref pResults);
		return result;
	}
	internal bool HandleControllerOverlayInteractionAsMouse(ulong ulOverlayHandle,uint unControllerDeviceIndex)
	{
		bool result = FnTable.HandleControllerOverlayInteractionAsMouse(ulOverlayHandle,unControllerDeviceIndex);
		return result;
	}
	internal bool IsHoverTargetOverlay(ulong ulOverlayHandle)
	{
		bool result = FnTable.IsHoverTargetOverlay(ulOverlayHandle);
		return result;
	}
	internal ulong GetGamepadFocusOverlay()
	{
		ulong result = FnTable.GetGamepadFocusOverlay();
		return result;
	}
	internal EVROverlayError SetGamepadFocusOverlay(ulong ulNewFocusOverlay)
	{
		EVROverlayError result = FnTable.SetGamepadFocusOverlay(ulNewFocusOverlay);
		return result;
	}
	internal EVROverlayError SetOverlayNeighbor(EOverlayDirection eDirection,ulong ulFrom,ulong ulTo)
	{
		EVROverlayError result = FnTable.SetOverlayNeighbor(eDirection,ulFrom,ulTo);
		return result;
	}
	internal EVROverlayError MoveGamepadFocusToNeighbor(EOverlayDirection eDirection,ulong ulFrom)
	{
		EVROverlayError result = FnTable.MoveGamepadFocusToNeighbor(eDirection,ulFrom);
		return result;
	}
	internal EVROverlayError SetOverlayTexture(ulong ulOverlayHandle,ref Texture_t pTexture)
	{
		EVROverlayError result = FnTable.SetOverlayTexture(ulOverlayHandle,ref pTexture);
		return result;
	}
	internal EVROverlayError ClearOverlayTexture(ulong ulOverlayHandle)
	{
		EVROverlayError result = FnTable.ClearOverlayTexture(ulOverlayHandle);
		return result;
	}
	internal EVROverlayError SetOverlayRaw(ulong ulOverlayHandle,IntPtr pvBuffer,uint unWidth,uint unHeight,uint unDepth)
	{
		EVROverlayError result = FnTable.SetOverlayRaw(ulOverlayHandle,pvBuffer,unWidth,unHeight,unDepth);
		return result;
	}
	internal EVROverlayError SetOverlayFromFile(ulong ulOverlayHandle,string pchFilePath)
	{
		EVROverlayError result = FnTable.SetOverlayFromFile(ulOverlayHandle,pchFilePath);
		return result;
	}
	internal EVROverlayError GetOverlayTexture(ulong ulOverlayHandle,ref IntPtr pNativeTextureHandle,IntPtr pNativeTextureRef,ref uint pWidth,ref uint pHeight,ref uint pNativeFormat,ref EGraphicsAPIConvention pAPI,ref EColorSpace pColorSpace)
	{
		pWidth = 0;
		pHeight = 0;
		pNativeFormat = 0;
		EVROverlayError result = FnTable.GetOverlayTexture(ulOverlayHandle,ref pNativeTextureHandle,pNativeTextureRef,ref pWidth,ref pHeight,ref pNativeFormat,ref pAPI,ref pColorSpace);
		return result;
	}
	internal EVROverlayError ReleaseNativeOverlayHandle(ulong ulOverlayHandle,IntPtr pNativeTextureHandle)
	{
		EVROverlayError result = FnTable.ReleaseNativeOverlayHandle(ulOverlayHandle,pNativeTextureHandle);
		return result;
	}
	internal EVROverlayError GetOverlayTextureSize(ulong ulOverlayHandle,ref uint pWidth,ref uint pHeight)
	{
		pWidth = 0;
		pHeight = 0;
		EVROverlayError result = FnTable.GetOverlayTextureSize(ulOverlayHandle,ref pWidth,ref pHeight);
		return result;
	}
	internal EVROverlayError CreateDashboardOverlay(string pchOverlayKey,string pchOverlayFriendlyName,ref ulong pMainHandle,ref ulong pThumbnailHandle)
	{
		pMainHandle = 0;
		pThumbnailHandle = 0;
		EVROverlayError result = FnTable.CreateDashboardOverlay(pchOverlayKey,pchOverlayFriendlyName,ref pMainHandle,ref pThumbnailHandle);
		return result;
	}
	internal bool IsDashboardVisible()
	{
		bool result = FnTable.IsDashboardVisible();
		return result;
	}
	internal bool IsActiveDashboardOverlay(ulong ulOverlayHandle)
	{
		bool result = FnTable.IsActiveDashboardOverlay(ulOverlayHandle);
		return result;
	}
	internal EVROverlayError SetDashboardOverlaySceneProcess(ulong ulOverlayHandle,uint unProcessId)
	{
		EVROverlayError result = FnTable.SetDashboardOverlaySceneProcess(ulOverlayHandle,unProcessId);
		return result;
	}
	internal EVROverlayError GetDashboardOverlaySceneProcess(ulong ulOverlayHandle,ref uint punProcessId)
	{
		punProcessId = 0;
		EVROverlayError result = FnTable.GetDashboardOverlaySceneProcess(ulOverlayHandle,ref punProcessId);
		return result;
	}
	internal void ShowDashboard(string pchOverlayToShow)
	{
		FnTable.ShowDashboard(pchOverlayToShow);
	}
	internal uint GetPrimaryDashboardDevice()
	{
		uint result = FnTable.GetPrimaryDashboardDevice();
		return result;
	}
	internal EVROverlayError ShowKeyboard(int eInputMode,int eLineInputMode,string pchDescription,uint unCharMax,string pchExistingText,bool bUseMinimalMode,ulong uUserValue)
	{
		EVROverlayError result = FnTable.ShowKeyboard(eInputMode,eLineInputMode,pchDescription,unCharMax,pchExistingText,bUseMinimalMode,uUserValue);
		return result;
	}
	internal EVROverlayError ShowKeyboardForOverlay(ulong ulOverlayHandle,int eInputMode,int eLineInputMode,string pchDescription,uint unCharMax,string pchExistingText,bool bUseMinimalMode,ulong uUserValue)
	{
		EVROverlayError result = FnTable.ShowKeyboardForOverlay(ulOverlayHandle,eInputMode,eLineInputMode,pchDescription,unCharMax,pchExistingText,bUseMinimalMode,uUserValue);
		return result;
	}
	internal uint GetKeyboardText(System.Text.StringBuilder pchText,uint cchText)
	{
		uint result = FnTable.GetKeyboardText(pchText,cchText);
		return result;
	}
	internal void HideKeyboard()
	{
		FnTable.HideKeyboard();
	}
	internal void SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin,ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform)
	{
		FnTable.SetKeyboardTransformAbsolute(eTrackingOrigin,ref pmatTrackingOriginToKeyboardTransform);
	}
	internal void SetKeyboardPositionForOverlay(ulong ulOverlayHandle,HmdRect2_t avoidRect)
	{
		FnTable.SetKeyboardPositionForOverlay(ulOverlayHandle,avoidRect);
	}
	internal EVROverlayError SetOverlayIntersectionMask(ulong ulOverlayHandle,ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives,uint unNumMaskPrimitives,uint unPrimitiveSize)
	{
		EVROverlayError result = FnTable.SetOverlayIntersectionMask(ulOverlayHandle,ref pMaskPrimitives,unNumMaskPrimitives,unPrimitiveSize);
		return result;
	}
}


internal class CVRRenderModels
{
	IVRRenderModels FnTable;
	internal CVRRenderModels(IntPtr pInterface)
	{
		FnTable = (IVRRenderModels)Marshal.PtrToStructure(pInterface, typeof(IVRRenderModels));
	}
	internal EVRRenderModelError LoadRenderModel_Async(string pchRenderModelName,ref IntPtr ppRenderModel)
	{
		EVRRenderModelError result = FnTable.LoadRenderModel_Async(pchRenderModelName,ref ppRenderModel);
		return result;
	}
	internal void FreeRenderModel(IntPtr pRenderModel)
	{
		FnTable.FreeRenderModel(pRenderModel);
	}
	internal EVRRenderModelError LoadTexture_Async(int textureId,ref IntPtr ppTexture)
	{
		EVRRenderModelError result = FnTable.LoadTexture_Async(textureId,ref ppTexture);
		return result;
	}
	internal void FreeTexture(IntPtr pTexture)
	{
		FnTable.FreeTexture(pTexture);
	}
	internal EVRRenderModelError LoadTextureD3D11_Async(int textureId,IntPtr pD3D11Device,ref IntPtr ppD3D11Texture2D)
	{
		EVRRenderModelError result = FnTable.LoadTextureD3D11_Async(textureId,pD3D11Device,ref ppD3D11Texture2D);
		return result;
	}
	internal EVRRenderModelError LoadIntoTextureD3D11_Async(int textureId,IntPtr pDstTexture)
	{
		EVRRenderModelError result = FnTable.LoadIntoTextureD3D11_Async(textureId,pDstTexture);
		return result;
	}
	internal void FreeTextureD3D11(IntPtr pD3D11Texture2D)
	{
		FnTable.FreeTextureD3D11(pD3D11Texture2D);
	}
	internal uint GetRenderModelName(uint unRenderModelIndex,System.Text.StringBuilder pchRenderModelName,uint unRenderModelNameLen)
	{
		uint result = FnTable.GetRenderModelName(unRenderModelIndex,pchRenderModelName,unRenderModelNameLen);
		return result;
	}
	internal uint GetRenderModelCount()
	{
		uint result = FnTable.GetRenderModelCount();
		return result;
	}
	internal uint GetComponentCount(string pchRenderModelName)
	{
		uint result = FnTable.GetComponentCount(pchRenderModelName);
		return result;
	}
	internal uint GetComponentName(string pchRenderModelName,uint unComponentIndex,System.Text.StringBuilder pchComponentName,uint unComponentNameLen)
	{
		uint result = FnTable.GetComponentName(pchRenderModelName,unComponentIndex,pchComponentName,unComponentNameLen);
		return result;
	}
	internal ulong GetComponentButtonMask(string pchRenderModelName,string pchComponentName)
	{
		ulong result = FnTable.GetComponentButtonMask(pchRenderModelName,pchComponentName);
		return result;
	}
	internal uint GetComponentRenderModelName(string pchRenderModelName,string pchComponentName,System.Text.StringBuilder pchComponentRenderModelName,uint unComponentRenderModelNameLen)
	{
		uint result = FnTable.GetComponentRenderModelName(pchRenderModelName,pchComponentName,pchComponentRenderModelName,unComponentRenderModelNameLen);
		return result;
	}
	internal bool GetComponentState(string pchRenderModelName,string pchComponentName,ref VRControllerState_t pControllerState,ref RenderModel_ControllerMode_State_t pState,ref RenderModel_ComponentState_t pComponentState)
	{
		bool result = FnTable.GetComponentState(pchRenderModelName,pchComponentName,ref pControllerState,ref pState,ref pComponentState);
		return result;
	}
	internal bool RenderModelHasComponent(string pchRenderModelName,string pchComponentName)
	{
		bool result = FnTable.RenderModelHasComponent(pchRenderModelName,pchComponentName);
		return result;
	}
	internal uint GetRenderModelThumbnailURL(string pchRenderModelName,System.Text.StringBuilder pchThumbnailURL,uint unThumbnailURLLen,ref EVRRenderModelError peError)
	{
		uint result = FnTable.GetRenderModelThumbnailURL(pchRenderModelName,pchThumbnailURL,unThumbnailURLLen,ref peError);
		return result;
	}
	internal uint GetRenderModelOriginalPath(string pchRenderModelName,System.Text.StringBuilder pchOriginalPath,uint unOriginalPathLen,ref EVRRenderModelError peError)
	{
		uint result = FnTable.GetRenderModelOriginalPath(pchRenderModelName,pchOriginalPath,unOriginalPathLen,ref peError);
		return result;
	}
	internal string GetRenderModelErrorNameFromEnum(EVRRenderModelError error)
	{
		IntPtr result = FnTable.GetRenderModelErrorNameFromEnum(error);
		return Marshal.PtrToStringAnsi(result);
	}
}


internal class CVRNotifications
{
	IVRNotifications FnTable;
	internal CVRNotifications(IntPtr pInterface)
	{
		FnTable = (IVRNotifications)Marshal.PtrToStructure(pInterface, typeof(IVRNotifications));
	}
	internal EVRNotificationError CreateNotification(ulong ulOverlayHandle,ulong ulUserValue,EVRNotificationType type,string pchText,EVRNotificationStyle style,ref NotificationBitmap_t pImage,ref uint pNotificationId)
	{
		pNotificationId = 0;
		EVRNotificationError result = FnTable.CreateNotification(ulOverlayHandle,ulUserValue,type,pchText,style,ref pImage,ref pNotificationId);
		return result;
	}
	internal EVRNotificationError RemoveNotification(uint notificationId)
	{
		EVRNotificationError result = FnTable.RemoveNotification(notificationId);
		return result;
	}
}


internal class CVRSettings
{
	IVRSettings FnTable;
	internal CVRSettings(IntPtr pInterface)
	{
		FnTable = (IVRSettings)Marshal.PtrToStructure(pInterface, typeof(IVRSettings));
	}
	internal string GetSettingsErrorNameFromEnum(EVRSettingsError eError)
	{
		IntPtr result = FnTable.GetSettingsErrorNameFromEnum(eError);
		return Marshal.PtrToStringAnsi(result);
	}
	internal bool Sync(bool bForce,ref EVRSettingsError peError)
	{
		bool result = FnTable.Sync(bForce,ref peError);
		return result;
	}
	internal void SetBool(string pchSection,string pchSettingsKey,bool bValue,ref EVRSettingsError peError)
	{
		FnTable.SetBool(pchSection,pchSettingsKey,bValue,ref peError);
	}
	internal void SetInt32(string pchSection,string pchSettingsKey,int nValue,ref EVRSettingsError peError)
	{
		FnTable.SetInt32(pchSection,pchSettingsKey,nValue,ref peError);
	}
	internal void SetFloat(string pchSection,string pchSettingsKey,float flValue,ref EVRSettingsError peError)
	{
		FnTable.SetFloat(pchSection,pchSettingsKey,flValue,ref peError);
	}
	internal void SetString(string pchSection,string pchSettingsKey,string pchValue,ref EVRSettingsError peError)
	{
		FnTable.SetString(pchSection,pchSettingsKey,pchValue,ref peError);
	}
	internal bool GetBool(string pchSection,string pchSettingsKey,ref EVRSettingsError peError)
	{
		bool result = FnTable.GetBool(pchSection,pchSettingsKey,ref peError);
		return result;
	}
	internal int GetInt32(string pchSection,string pchSettingsKey,ref EVRSettingsError peError)
	{
		int result = FnTable.GetInt32(pchSection,pchSettingsKey,ref peError);
		return result;
	}
	internal float GetFloat(string pchSection,string pchSettingsKey,ref EVRSettingsError peError)
	{
		float result = FnTable.GetFloat(pchSection,pchSettingsKey,ref peError);
		return result;
	}
	internal void GetString(string pchSection,string pchSettingsKey,System.Text.StringBuilder pchValue,uint unValueLen,ref EVRSettingsError peError)
	{
		FnTable.GetString(pchSection,pchSettingsKey,pchValue,unValueLen,ref peError);
	}
	internal void RemoveSection(string pchSection,ref EVRSettingsError peError)
	{
		FnTable.RemoveSection(pchSection,ref peError);
	}
	internal void RemoveKeyInSection(string pchSection,string pchSettingsKey,ref EVRSettingsError peError)
	{
		FnTable.RemoveKeyInSection(pchSection,pchSettingsKey,ref peError);
	}
}


internal class CVRScreenshots
{
	IVRScreenshots FnTable;
	internal CVRScreenshots(IntPtr pInterface)
	{
		FnTable = (IVRScreenshots)Marshal.PtrToStructure(pInterface, typeof(IVRScreenshots));
	}
	internal EVRScreenshotError RequestScreenshot(ref uint pOutScreenshotHandle,EVRScreenshotType type,string pchPreviewFilename,string pchVRFilename)
	{
		pOutScreenshotHandle = 0;
		EVRScreenshotError result = FnTable.RequestScreenshot(ref pOutScreenshotHandle,type,pchPreviewFilename,pchVRFilename);
		return result;
	}
	internal EVRScreenshotError HookScreenshot(EVRScreenshotType [] pSupportedTypes)
	{
		EVRScreenshotError result = FnTable.HookScreenshot(pSupportedTypes,(int) pSupportedTypes.Length);
		return result;
	}
	internal EVRScreenshotType GetScreenshotPropertyType(uint screenshotHandle,ref EVRScreenshotError pError)
	{
		EVRScreenshotType result = FnTable.GetScreenshotPropertyType(screenshotHandle,ref pError);
		return result;
	}
	internal uint GetScreenshotPropertyFilename(uint screenshotHandle,EVRScreenshotPropertyFilenames filenameType,System.Text.StringBuilder pchFilename,uint cchFilename,ref EVRScreenshotError pError)
	{
		uint result = FnTable.GetScreenshotPropertyFilename(screenshotHandle,filenameType,pchFilename,cchFilename,ref pError);
		return result;
	}
	internal EVRScreenshotError UpdateScreenshotProgress(uint screenshotHandle,float flProgress)
	{
		EVRScreenshotError result = FnTable.UpdateScreenshotProgress(screenshotHandle,flProgress);
		return result;
	}
	internal EVRScreenshotError TakeStereoScreenshot(ref uint pOutScreenshotHandle,string pchPreviewFilename,string pchVRFilename)
	{
		pOutScreenshotHandle = 0;
		EVRScreenshotError result = FnTable.TakeStereoScreenshot(ref pOutScreenshotHandle,pchPreviewFilename,pchVRFilename);
		return result;
	}
	internal EVRScreenshotError SubmitScreenshot(uint screenshotHandle,EVRScreenshotType type,string pchSourcePreviewFilename,string pchSourceVRFilename)
	{
		EVRScreenshotError result = FnTable.SubmitScreenshot(screenshotHandle,type,pchSourcePreviewFilename,pchSourceVRFilename);
		return result;
	}
}


internal class CVRResources
{
	IVRResources FnTable;
	internal CVRResources(IntPtr pInterface)
	{
		FnTable = (IVRResources)Marshal.PtrToStructure(pInterface, typeof(IVRResources));
	}
	internal uint LoadSharedResource(string pchResourceName,string pchBuffer,uint unBufferLen)
	{
		uint result = FnTable.LoadSharedResource(pchResourceName,pchBuffer,unBufferLen);
		return result;
	}
	internal uint GetResourceFullPath(string pchResourceName,string pchResourceTypeDirectory,string pchPathBuffer,uint unBufferLen)
	{
		uint result = FnTable.GetResourceFullPath(pchResourceName,pchResourceTypeDirectory,pchPathBuffer,unBufferLen);
		return result;
	}
}


internal class OpenVRInterop
{
	[DllImportAttribute("openvr_api", EntryPoint = "VR_InitInternal", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType);
	[DllImportAttribute("openvr_api", EntryPoint = "VR_ShutdownInternal", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void ShutdownInternal();
	[DllImportAttribute("openvr_api", EntryPoint = "VR_IsHmdPresent", CallingConvention = CallingConvention.Cdecl)]
	internal static extern bool IsHmdPresent();
	[DllImportAttribute("openvr_api", EntryPoint = "VR_IsRuntimeInstalled", CallingConvention = CallingConvention.Cdecl)]
	internal static extern bool IsRuntimeInstalled();
	[DllImportAttribute("openvr_api", EntryPoint = "VR_GetStringForHmdError", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr GetStringForHmdError(EVRInitError error);
	[DllImportAttribute("openvr_api", EntryPoint = "VR_GetGenericInterface", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr GetGenericInterface([In, MarshalAs(UnmanagedType.LPStr)] string pchInterfaceVersion, ref EVRInitError peError);
	[DllImportAttribute("openvr_api", EntryPoint = "VR_IsInterfaceVersionValid", CallingConvention = CallingConvention.Cdecl)]
	internal static extern bool IsInterfaceVersionValid([In, MarshalAs(UnmanagedType.LPStr)] string pchInterfaceVersion);
	[DllImportAttribute("openvr_api", EntryPoint = "VR_GetInitToken", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint GetInitToken();
}


internal enum EVREye
{
	Eye_Left = 0,
	Eye_Right = 1,
}
internal enum EGraphicsAPIConvention
{
	API_DirectX = 0,
	API_OpenGL = 1,
}
internal enum EColorSpace
{
	Auto = 0,
	Gamma = 1,
	Linear = 2,
}
internal enum ETrackingResult
{
	Uninitialized = 1,
	Calibrating_InProgress = 100,
	Calibrating_OutOfRange = 101,
	Running_OK = 200,
	Running_OutOfRange = 201,
}
internal enum ETrackedDeviceClass
{
	Invalid = 0,
	HMD = 1,
	Controller = 2,
	TrackingReference = 4,
	Count = 5,
	Other = 1000,
}
internal enum ETrackedControllerRole
{
	Invalid = 0,
	LeftHand = 1,
	RightHand = 2,
}
internal enum ETrackingUniverseOrigin
{
	TrackingUniverseSeated = 0,
	TrackingUniverseStanding = 1,
	TrackingUniverseRawAndUncalibrated = 2,
}
internal enum ETrackedDeviceProperty
{
	Prop_TrackingSystemName_String = 1000,
	Prop_ModelNumber_String = 1001,
	Prop_SerialNumber_String = 1002,
	Prop_RenderModelName_String = 1003,
	Prop_WillDriftInYaw_Bool = 1004,
	Prop_ManufacturerName_String = 1005,
	Prop_TrackingFirmwareVersion_String = 1006,
	Prop_HardwareRevision_String = 1007,
	Prop_AllWirelessDongleDescriptions_String = 1008,
	Prop_ConnectedWirelessDongle_String = 1009,
	Prop_DeviceIsWireless_Bool = 1010,
	Prop_DeviceIsCharging_Bool = 1011,
	Prop_DeviceBatteryPercentage_Float = 1012,
	Prop_StatusDisplayTransform_Matrix34 = 1013,
	Prop_Firmware_UpdateAvailable_Bool = 1014,
	Prop_Firmware_ManualUpdate_Bool = 1015,
	Prop_Firmware_ManualUpdateURL_String = 1016,
	Prop_HardwareRevision_Uint64 = 1017,
	Prop_FirmwareVersion_Uint64 = 1018,
	Prop_FPGAVersion_Uint64 = 1019,
	Prop_VRCVersion_Uint64 = 1020,
	Prop_RadioVersion_Uint64 = 1021,
	Prop_DongleVersion_Uint64 = 1022,
	Prop_BlockServerShutdown_Bool = 1023,
	Prop_CanUnifyCoordinateSystemWithHmd_Bool = 1024,
	Prop_ContainsProximitySensor_Bool = 1025,
	Prop_DeviceProvidesBatteryStatus_Bool = 1026,
	Prop_DeviceCanPowerOff_Bool = 1027,
	Prop_Firmware_ProgrammingTarget_String = 1028,
	Prop_DeviceClass_Int32 = 1029,
	Prop_HasCamera_Bool = 1030,
	Prop_DriverVersion_String = 1031,
	Prop_Firmware_ForceUpdateRequired_Bool = 1032,
	Prop_ViveSystemButtonFixRequired_Bool = 1033,
	Prop_ReportsTimeSinceVSync_Bool = 2000,
	Prop_SecondsFromVsyncToPhotons_Float = 2001,
	Prop_DisplayFrequency_Float = 2002,
	Prop_UserIpdMeters_Float = 2003,
	Prop_CurrentUniverseId_Uint64 = 2004,
	Prop_PreviousUniverseId_Uint64 = 2005,
	Prop_DisplayFirmwareVersion_Uint64 = 2006,
	Prop_IsOnDesktop_Bool = 2007,
	Prop_DisplayMCType_Int32 = 2008,
	Prop_DisplayMCOffset_Float = 2009,
	Prop_DisplayMCScale_Float = 2010,
	Prop_EdidVendorID_Int32 = 2011,
	Prop_DisplayMCImageLeft_String = 2012,
	Prop_DisplayMCImageRight_String = 2013,
	Prop_DisplayGCBlackClamp_Float = 2014,
	Prop_EdidProductID_Int32 = 2015,
	Prop_CameraToHeadTransform_Matrix34 = 2016,
	Prop_DisplayGCType_Int32 = 2017,
	Prop_DisplayGCOffset_Float = 2018,
	Prop_DisplayGCScale_Float = 2019,
	Prop_DisplayGCPrescale_Float = 2020,
	Prop_DisplayGCImage_String = 2021,
	Prop_LensCenterLeftU_Float = 2022,
	Prop_LensCenterLeftV_Float = 2023,
	Prop_LensCenterRightU_Float = 2024,
	Prop_LensCenterRightV_Float = 2025,
	Prop_UserHeadToEyeDepthMeters_Float = 2026,
	Prop_CameraFirmwareVersion_Uint64 = 2027,
	Prop_CameraFirmwareDescription_String = 2028,
	Prop_DisplayFPGAVersion_Uint64 = 2029,
	Prop_DisplayBootloaderVersion_Uint64 = 2030,
	Prop_DisplayHardwareVersion_Uint64 = 2031,
	Prop_AudioFirmwareVersion_Uint64 = 2032,
	Prop_CameraCompatibilityMode_Int32 = 2033,
	Prop_ScreenshotHorizontalFieldOfViewDegrees_Float = 2034,
	Prop_ScreenshotVerticalFieldOfViewDegrees_Float = 2035,
	Prop_DisplaySuppressed_Bool = 2036,
	Prop_DisplayAllowNightMode_Bool = 2037,
	Prop_AttachedDeviceId_String = 3000,
	Prop_SupportedButtons_Uint64 = 3001,
	Prop_Axis0Type_Int32 = 3002,
	Prop_Axis1Type_Int32 = 3003,
	Prop_Axis2Type_Int32 = 3004,
	Prop_Axis3Type_Int32 = 3005,
	Prop_Axis4Type_Int32 = 3006,
	Prop_ControllerRoleHint_Int32 = 3007,
	Prop_FieldOfViewLeftDegrees_Float = 4000,
	Prop_FieldOfViewRightDegrees_Float = 4001,
	Prop_FieldOfViewTopDegrees_Float = 4002,
	Prop_FieldOfViewBottomDegrees_Float = 4003,
	Prop_TrackingRangeMinimumMeters_Float = 4004,
	Prop_TrackingRangeMaximumMeters_Float = 4005,
	Prop_ModeLabel_String = 4006,
	Prop_IconPathName_String = 5000,
	Prop_NamedIconPathDeviceOff_String = 5001,
	Prop_NamedIconPathDeviceSearching_String = 5002,
	Prop_NamedIconPathDeviceSearchingAlert_String = 5003,
	Prop_NamedIconPathDeviceReady_String = 5004,
	Prop_NamedIconPathDeviceReadyAlert_String = 5005,
	Prop_NamedIconPathDeviceNotReady_String = 5006,
	Prop_NamedIconPathDeviceStandby_String = 5007,
	Prop_NamedIconPathDeviceAlertLow_String = 5008,
	Prop_VendorSpecific_Reserved_Start = 10000,
	Prop_VendorSpecific_Reserved_End = 10999,
}
internal enum ETrackedPropertyError
{
	TrackedProp_Success = 0,
	TrackedProp_WrongDataType = 1,
	TrackedProp_WrongDeviceClass = 2,
	TrackedProp_BufferTooSmall = 3,
	TrackedProp_UnknownProperty = 4,
	TrackedProp_InvalidDevice = 5,
	TrackedProp_CouldNotContactServer = 6,
	TrackedProp_ValueNotProvidedByDevice = 7,
	TrackedProp_StringExceedsMaximumLength = 8,
	TrackedProp_NotYetAvailable = 9,
}
internal enum EVRSubmitFlags
{
	Submit_Default = 0,
	Submit_LensDistortionAlreadyApplied = 1,
	Submit_GlRenderBuffer = 2,
	Submit_VulkanTexture = 4,
}
internal enum EVRState
{
	Undefined = -1,
	Off = 0,
	Searching = 1,
	Searching_Alert = 2,
	Ready = 3,
	Ready_Alert = 4,
	NotReady = 5,
	Standby = 6,
	Ready_Alert_Low = 7,
}
internal enum EVREventType
{
	VREvent_None = 0,
	VREvent_TrackedDeviceActivated = 100,
	VREvent_TrackedDeviceDeactivated = 101,
	VREvent_TrackedDeviceUpdated = 102,
	VREvent_TrackedDeviceUserInteractionStarted = 103,
	VREvent_TrackedDeviceUserInteractionEnded = 104,
	VREvent_IpdChanged = 105,
	VREvent_EnterStandbyMode = 106,
	VREvent_LeaveStandbyMode = 107,
	VREvent_TrackedDeviceRoleChanged = 108,
	VREvent_WatchdogWakeUpRequested = 109,
	VREvent_LensDistortionChanged = 110,
	VREvent_ButtonPress = 200,
	VREvent_ButtonUnpress = 201,
	VREvent_ButtonTouch = 202,
	VREvent_ButtonUntouch = 203,
	VREvent_MouseMove = 300,
	VREvent_MouseButtonDown = 301,
	VREvent_MouseButtonUp = 302,
	VREvent_FocusEnter = 303,
	VREvent_FocusLeave = 304,
	VREvent_Scroll = 305,
	VREvent_TouchPadMove = 306,
	VREvent_OverlayFocusChanged = 307,
	VREvent_InputFocusCaptured = 400,
	VREvent_InputFocusReleased = 401,
	VREvent_SceneFocusLost = 402,
	VREvent_SceneFocusGained = 403,
	VREvent_SceneApplicationChanged = 404,
	VREvent_SceneFocusChanged = 405,
	VREvent_InputFocusChanged = 406,
	VREvent_SceneApplicationSecondaryRenderingStarted = 407,
	VREvent_HideRenderModels = 410,
	VREvent_ShowRenderModels = 411,
	VREvent_OverlayShown = 500,
	VREvent_OverlayHidden = 501,
	VREvent_DashboardActivated = 502,
	VREvent_DashboardDeactivated = 503,
	VREvent_DashboardThumbSelected = 504,
	VREvent_DashboardRequested = 505,
	VREvent_ResetDashboard = 506,
	VREvent_RenderToast = 507,
	VREvent_ImageLoaded = 508,
	VREvent_ShowKeyboard = 509,
	VREvent_HideKeyboard = 510,
	VREvent_OverlayGamepadFocusGained = 511,
	VREvent_OverlayGamepadFocusLost = 512,
	VREvent_OverlaySharedTextureChanged = 513,
	VREvent_DashboardGuideButtonDown = 514,
	VREvent_DashboardGuideButtonUp = 515,
	VREvent_ScreenshotTriggered = 516,
	VREvent_ImageFailed = 517,
	VREvent_DashboardOverlayCreated = 518,
	VREvent_RequestScreenshot = 520,
	VREvent_ScreenshotTaken = 521,
	VREvent_ScreenshotFailed = 522,
	VREvent_SubmitScreenshotToDashboard = 523,
	VREvent_ScreenshotProgressToDashboard = 524,
	VREvent_Notification_Shown = 600,
	VREvent_Notification_Hidden = 601,
	VREvent_Notification_BeginInteraction = 602,
	VREvent_Notification_Destroyed = 603,
	VREvent_Quit = 700,
	VREvent_ProcessQuit = 701,
	VREvent_QuitAborted_UserPrompt = 702,
	VREvent_QuitAcknowledged = 703,
	VREvent_DriverRequestedQuit = 704,
	VREvent_ChaperoneDataHasChanged = 800,
	VREvent_ChaperoneUniverseHasChanged = 801,
	VREvent_ChaperoneTempDataHasChanged = 802,
	VREvent_ChaperoneSettingsHaveChanged = 803,
	VREvent_SeatedZeroPoseReset = 804,
	VREvent_AudioSettingsHaveChanged = 820,
	VREvent_BackgroundSettingHasChanged = 850,
	VREvent_CameraSettingsHaveChanged = 851,
	VREvent_ReprojectionSettingHasChanged = 852,
	VREvent_ModelSkinSettingsHaveChanged = 853,
	VREvent_EnvironmentSettingsHaveChanged = 854,
	VREvent_PowerSettingsHaveChanged = 855,
	VREvent_StatusUpdate = 900,
	VREvent_MCImageUpdated = 1000,
	VREvent_FirmwareUpdateStarted = 1100,
	VREvent_FirmwareUpdateFinished = 1101,
	VREvent_KeyboardClosed = 1200,
	VREvent_KeyboardCharInput = 1201,
	VREvent_KeyboardDone = 1202,
	VREvent_ApplicationTransitionStarted = 1300,
	VREvent_ApplicationTransitionAborted = 1301,
	VREvent_ApplicationTransitionNewAppStarted = 1302,
	VREvent_ApplicationListUpdated = 1303,
	VREvent_ApplicationMimeTypeLoad = 1304,
	VREvent_Compositor_MirrorWindowShown = 1400,
	VREvent_Compositor_MirrorWindowHidden = 1401,
	VREvent_Compositor_ChaperoneBoundsShown = 1410,
	VREvent_Compositor_ChaperoneBoundsHidden = 1411,
	VREvent_TrackedCamera_StartVideoStream = 1500,
	VREvent_TrackedCamera_StopVideoStream = 1501,
	VREvent_TrackedCamera_PauseVideoStream = 1502,
	VREvent_TrackedCamera_ResumeVideoStream = 1503,
	VREvent_TrackedCamera_EditingSurface = 1550,
	VREvent_PerformanceTest_EnableCapture = 1600,
	VREvent_PerformanceTest_DisableCapture = 1601,
	VREvent_PerformanceTest_FidelityLevel = 1602,
	VREvent_VendorSpecific_Reserved_Start = 10000,
	VREvent_VendorSpecific_Reserved_End = 19999,
}
internal enum EDeviceActivityLevel
{
	k_EDeviceActivityLevel_Unknown = -1,
	k_EDeviceActivityLevel_Idle = 0,
	k_EDeviceActivityLevel_UserInteraction = 1,
	k_EDeviceActivityLevel_UserInteraction_Timeout = 2,
	k_EDeviceActivityLevel_Standby = 3,
}
internal enum EVRButtonId
{
	k_EButton_System = 0,
	k_EButton_ApplicationMenu = 1,
	k_EButton_Grip = 2,
	k_EButton_DPad_Left = 3,
	k_EButton_DPad_Up = 4,
	k_EButton_DPad_Right = 5,
	k_EButton_DPad_Down = 6,
	k_EButton_A = 7,
	k_EButton_ProximitySensor = 31,
	k_EButton_Axis0 = 32,
	k_EButton_Axis1 = 33,
	k_EButton_Axis2 = 34,
	k_EButton_Axis3 = 35,
	k_EButton_Axis4 = 36,
	k_EButton_SteamVR_Touchpad = 32,
	k_EButton_SteamVR_Trigger = 33,
	k_EButton_Dashboard_Back = 2,
	k_EButton_Max = 64,
}
internal enum EVRMouseButton
{
	Left = 1,
	Right = 2,
	Middle = 4,
}
internal enum EHiddenAreaMeshType
{
	k_eHiddenAreaMesh_Standard = 0,
	k_eHiddenAreaMesh_Inverse = 1,
	k_eHiddenAreaMesh_LineLoop = 2,
}
internal enum EVRControllerAxisType
{
	k_eControllerAxis_None = 0,
	k_eControllerAxis_TrackPad = 1,
	k_eControllerAxis_Joystick = 2,
	k_eControllerAxis_Trigger = 3,
}
internal enum EVRControllerEventOutputType
{
	ControllerEventOutput_OSEvents = 0,
	ControllerEventOutput_VREvents = 1,
}
internal enum ECollisionBoundsStyle
{
	COLLISION_BOUNDS_STYLE_BEGINNER = 0,
	COLLISION_BOUNDS_STYLE_INTERMEDIATE = 1,
	COLLISION_BOUNDS_STYLE_SQUARES = 2,
	COLLISION_BOUNDS_STYLE_ADVANCED = 3,
	COLLISION_BOUNDS_STYLE_NONE = 4,
	COLLISION_BOUNDS_STYLE_COUNT = 5,
}
internal enum EVROverlayError
{
	None = 0,
	UnknownOverlay = 10,
	InvalidHandle = 11,
	PermissionDenied = 12,
	OverlayLimitExceeded = 13,
	WrongVisibilityType = 14,
	KeyTooLong = 15,
	NameTooLong = 16,
	KeyInUse = 17,
	WrongTransformType = 18,
	InvalidTrackedDevice = 19,
	InvalidParameter = 20,
	ThumbnailCantBeDestroyed = 21,
	ArrayTooSmall = 22,
	RequestFailed = 23,
	InvalidTexture = 24,
	UnableToLoadFile = 25,
	KeyboardAlreadyInUse = 26,
	NoNeighbor = 27,
	TooManyMaskPrimitives = 29,
	BadMaskPrimitive = 30,
}
internal enum EVRApplicationType
{
	VRApplication_Other = 0,
	VRApplication_Scene = 1,
	VRApplication_Overlay = 2,
	VRApplication_Background = 3,
	VRApplication_Utility = 4,
	VRApplication_VRMonitor = 5,
	VRApplication_SteamWatchdog = 6,
	VRApplication_Max = 7,
}
internal enum EVRFirmwareError
{
	None = 0,
	Success = 1,
	Fail = 2,
}
internal enum EVRNotificationError
{
	OK = 0,
	InvalidNotificationId = 100,
	NotificationQueueFull = 101,
	InvalidOverlayHandle = 102,
	SystemWithUserValueAlreadyExists = 103,
}
internal enum EVRInitError
{
	None = 0,
	Unknown = 1,
	Init_InstallationNotFound = 100,
	Init_InstallationCorrupt = 101,
	Init_VRClientDLLNotFound = 102,
	Init_FileNotFound = 103,
	Init_FactoryNotFound = 104,
	Init_InterfaceNotFound = 105,
	Init_InvalidInterface = 106,
	Init_UserConfigDirectoryInvalid = 107,
	Init_HmdNotFound = 108,
	Init_NotInitialized = 109,
	Init_PathRegistryNotFound = 110,
	Init_NoConfigPath = 111,
	Init_NoLogPath = 112,
	Init_PathRegistryNotWritable = 113,
	Init_AppInfoInitFailed = 114,
	Init_Retry = 115,
	Init_InitCanceledByUser = 116,
	Init_AnotherAppLaunching = 117,
	Init_SettingsInitFailed = 118,
	Init_ShuttingDown = 119,
	Init_TooManyObjects = 120,
	Init_NoServerForBackgroundApp = 121,
	Init_NotSupportedWithCompositor = 122,
	Init_NotAvailableToUtilityApps = 123,
	Init_Internal = 124,
	Init_HmdDriverIdIsNone = 125,
	Init_HmdNotFoundPresenceFailed = 126,
	Init_VRMonitorNotFound = 127,
	Init_VRMonitorStartupFailed = 128,
	Init_LowPowerWatchdogNotSupported = 129,
	Init_InvalidApplicationType = 130,
	Init_NotAvailableToWatchdogApps = 131,
	Init_WatchdogDisabledInSettings = 132,
	Driver_Failed = 200,
	Driver_Unknown = 201,
	Driver_HmdUnknown = 202,
	Driver_NotLoaded = 203,
	Driver_RuntimeOutOfDate = 204,
	Driver_HmdInUse = 205,
	Driver_NotCalibrated = 206,
	Driver_CalibrationInvalid = 207,
	Driver_HmdDisplayNotFound = 208,
	Driver_TrackedDeviceInterfaceUnknown = 209,
	Driver_HmdDriverIdOutOfBounds = 211,
	Driver_HmdDisplayMirrored = 212,
	IPC_ServerInitFailed = 300,
	IPC_ConnectFailed = 301,
	IPC_SharedStateInitFailed = 302,
	IPC_CompositorInitFailed = 303,
	IPC_MutexInitFailed = 304,
	IPC_Failed = 305,
	IPC_CompositorConnectFailed = 306,
	IPC_CompositorInvalidConnectResponse = 307,
	IPC_ConnectFailedAfterMultipleAttempts = 308,
	Compositor_Failed = 400,
	Compositor_D3D11HardwareRequired = 401,
	Compositor_FirmwareRequiresUpdate = 402,
	Compositor_OverlayInitFailed = 403,
	Compositor_ScreenshotsInitFailed = 404,
	VendorSpecific_UnableToConnectToOculusRuntime = 1000,
	VendorSpecific_HmdFound_CantOpenDevice = 1101,
	VendorSpecific_HmdFound_UnableToRequestConfigStart = 1102,
	VendorSpecific_HmdFound_NoStoredConfig = 1103,
	VendorSpecific_HmdFound_ConfigTooBig = 1104,
	VendorSpecific_HmdFound_ConfigTooSmall = 1105,
	VendorSpecific_HmdFound_UnableToInitZLib = 1106,
	VendorSpecific_HmdFound_CantReadFirmwareVersion = 1107,
	VendorSpecific_HmdFound_UnableToSendUserDataStart = 1108,
	VendorSpecific_HmdFound_UnableToGetUserDataStart = 1109,
	VendorSpecific_HmdFound_UnableToGetUserDataNext = 1110,
	VendorSpecific_HmdFound_UserDataAddressRange = 1111,
	VendorSpecific_HmdFound_UserDataError = 1112,
	VendorSpecific_HmdFound_ConfigFailedSanityCheck = 1113,
	Steam_SteamInstallationNotFound = 2000,
}
internal enum EVRScreenshotType
{
	None = 0,
	Mono = 1,
	Stereo = 2,
	Cubemap = 3,
	MonoPanorama = 4,
	StereoPanorama = 5,
}
internal enum EVRScreenshotPropertyFilenames
{
	Preview = 0,
	VR = 1,
}
internal enum EVRTrackedCameraError
{
	None = 0,
	OperationFailed = 100,
	InvalidHandle = 101,
	InvalidFrameHeaderVersion = 102,
	OutOfHandles = 103,
	IPCFailure = 104,
	NotSupportedForThisDevice = 105,
	SharedMemoryFailure = 106,
	FrameBufferingFailure = 107,
	StreamSetupFailure = 108,
	InvalidGLTextureId = 109,
	InvalidSharedTextureHandle = 110,
	FailedToGetGLTextureId = 111,
	SharedTextureFailure = 112,
	NoFrameAvailable = 113,
	InvalidArgument = 114,
	InvalidFrameBufferSize = 115,
}
internal enum EVRTrackedCameraFrameType
{
	Distorted = 0,
	Undistorted = 1,
	MaximumUndistorted = 2,
	MAX_CAMERA_FRAME_TYPES = 3,
}
internal enum EVRApplicationError
{
	None = 0,
	AppKeyAlreadyExists = 100,
	NoManifest = 101,
	NoApplication = 102,
	InvalidIndex = 103,
	UnknownApplication = 104,
	IPCFailed = 105,
	ApplicationAlreadyRunning = 106,
	InvalidManifest = 107,
	InvalidApplication = 108,
	LaunchFailed = 109,
	ApplicationAlreadyStarting = 110,
	LaunchInProgress = 111,
	OldApplicationQuitting = 112,
	TransitionAborted = 113,
	IsTemplate = 114,
	BufferTooSmall = 200,
	PropertyNotSet = 201,
	UnknownProperty = 202,
	InvalidParameter = 203,
}
internal enum EVRApplicationProperty
{
	Name_String = 0,
	LaunchType_String = 11,
	WorkingDirectory_String = 12,
	BinaryPath_String = 13,
	Arguments_String = 14,
	URL_String = 15,
	Description_String = 50,
	NewsURL_String = 51,
	ImagePath_String = 52,
	Source_String = 53,
	IsDashboardOverlay_Bool = 60,
	IsTemplate_Bool = 61,
	IsInstanced_Bool = 62,
	LastLaunchTime_Uint64 = 70,
}
internal enum EVRApplicationTransitionState
{
	VRApplicationTransition_None = 0,
	VRApplicationTransition_OldAppQuitSent = 10,
	VRApplicationTransition_WaitingForExternalLaunch = 11,
	VRApplicationTransition_NewAppLaunched = 20,
}
internal enum ChaperoneCalibrationState
{
	OK = 1,
	Warning = 100,
	Warning_BaseStationMayHaveMoved = 101,
	Warning_BaseStationRemoved = 102,
	Warning_SeatedBoundsInvalid = 103,
	Error = 200,
	Error_BaseStationUninitalized = 201,
	Error_BaseStationConflict = 202,
	Error_PlayAreaInvalid = 203,
	Error_CollisionBoundsInvalid = 204,
}
internal enum EChaperoneConfigFile
{
	Live = 1,
	Temp = 2,
}
internal enum EChaperoneImportFlags
{
	EChaperoneImport_BoundsOnly = 1,
}
internal enum EVRCompositorError
{
	None = 0,
	RequestFailed = 1,
	IncompatibleVersion = 100,
	DoNotHaveFocus = 101,
	InvalidTexture = 102,
	IsNotSceneApplication = 103,
	TextureIsOnWrongDevice = 104,
	TextureUsesUnsupportedFormat = 105,
	SharedTexturesNotSupported = 106,
	IndexOutOfRange = 107,
	AlreadySubmitted = 108,
}
internal enum VROverlayInputMethod
{
	None = 0,
	Mouse = 1,
}
internal enum VROverlayTransformType
{
	VROverlayTransform_Absolute = 0,
	VROverlayTransform_TrackedDeviceRelative = 1,
	VROverlayTransform_SystemOverlay = 2,
	VROverlayTransform_TrackedComponent = 3,
}
internal enum VROverlayFlags
{
	None = 0,
	Curved = 1,
	RGSS4X = 2,
	NoDashboardTab = 3,
	AcceptsGamepadEvents = 4,
	ShowGamepadFocus = 5,
	SendVRScrollEvents = 6,
	SendVRTouchpadEvents = 7,
	ShowTouchPadScrollWheel = 8,
	TransferOwnershipToInternalProcess = 9,
	SideBySide_Parallel = 10,
	SideBySide_Crossed = 11,
	Panorama = 12,
	StereoPanorama = 13,
	SortWithNonSceneOverlays = 14,
}
internal enum EGamepadTextInputMode
{
	k_EGamepadTextInputModeNormal = 0,
	k_EGamepadTextInputModePassword = 1,
	k_EGamepadTextInputModeSubmit = 2,
}
internal enum EGamepadTextInputLineMode
{
	k_EGamepadTextInputLineModeSingleLine = 0,
	k_EGamepadTextInputLineModeMultipleLines = 1,
}
internal enum EOverlayDirection
{
	Up = 0,
	Down = 1,
	Left = 2,
	Right = 3,
	Count = 4,
}
internal enum EVROverlayIntersectionMaskPrimitiveType
{
	OverlayIntersectionPrimitiveType_Rectangle = 0,
	OverlayIntersectionPrimitiveType_Circle = 1,
}
internal enum EVRRenderModelError
{
	None = 0,
	Loading = 100,
	NotSupported = 200,
	InvalidArg = 300,
	InvalidModel = 301,
	NoShapes = 302,
	MultipleShapes = 303,
	TooManyVertices = 304,
	MultipleTextures = 305,
	BufferTooSmall = 306,
	NotEnoughNormals = 307,
	NotEnoughTexCoords = 308,
	InvalidTexture = 400,
}
internal enum EVRComponentProperty
{
	IsStatic = 1,
	IsVisible = 2,
	IsTouched = 4,
	IsPressed = 8,
	IsScrolled = 16,
}
internal enum EVRNotificationType
{
	Transient = 0,
	Persistent = 1,
	Transient_SystemWithUserValue = 2,
}
internal enum EVRNotificationStyle
{
	None = 0,
	Application = 100,
	Contact_Disabled = 200,
	Contact_Enabled = 201,
	Contact_Active = 202,
}
internal enum EVRSettingsError
{
	None = 0,
	IPCFailed = 1,
	WriteFailed = 2,
	ReadFailed = 3,
	JsonParseFailed = 4,
	UnsetSettingHasNoDefault = 5,
}
internal enum EVRScreenshotError
{
	None = 0,
	RequestFailed = 1,
	IncompatibleVersion = 100,
	NotFound = 101,
	BufferTooSmall = 102,
	ScreenshotAlreadyInProgress = 108,
}

[StructLayout(LayoutKind.Explicit)] internal struct VREvent_Data_t
{
	[FieldOffset(0)] internal VREvent_Reserved_t reserved;
	[FieldOffset(0)] internal VREvent_Controller_t controller;
	[FieldOffset(0)] internal VREvent_Mouse_t mouse;
	[FieldOffset(0)] internal VREvent_Scroll_t scroll;
	[FieldOffset(0)] internal VREvent_Process_t process;
	[FieldOffset(0)] internal VREvent_Notification_t notification;
	[FieldOffset(0)] internal VREvent_Overlay_t overlay;
	[FieldOffset(0)] internal VREvent_Status_t status;
	[FieldOffset(0)] internal VREvent_Ipd_t ipd;
	[FieldOffset(0)] internal VREvent_Chaperone_t chaperone;
	[FieldOffset(0)] internal VREvent_PerformanceTest_t performanceTest;
	[FieldOffset(0)] internal VREvent_TouchPadMove_t touchPadMove;
	[FieldOffset(0)] internal VREvent_SeatedZeroPoseReset_t seatedZeroPoseReset;
	[FieldOffset(0)] internal VREvent_Screenshot_t screenshot;
	[FieldOffset(0)] internal VREvent_Keyboard_t keyboard; // This has to be at the end due to a mono bug
}


[StructLayout(LayoutKind.Explicit)] internal struct VROverlayIntersectionMaskPrimitive_Data_t
{
	[FieldOffset(0)] internal IntersectionMaskRectangle_t m_Rectangle;
	[FieldOffset(0)] internal IntersectionMaskCircle_t m_Circle;
}

[StructLayout(LayoutKind.Sequential)] internal struct HmdMatrix34_t
{
	internal float m0; //float[3][4]
	internal float m1;
	internal float m2;
	internal float m3;
	internal float m4;
	internal float m5;
	internal float m6;
	internal float m7;
	internal float m8;
	internal float m9;
	internal float m10;
	internal float m11;
}
[StructLayout(LayoutKind.Sequential)] internal struct HmdMatrix44_t
{
	internal float m0; //float[4][4]
	internal float m1;
	internal float m2;
	internal float m3;
	internal float m4;
	internal float m5;
	internal float m6;
	internal float m7;
	internal float m8;
	internal float m9;
	internal float m10;
	internal float m11;
	internal float m12;
	internal float m13;
	internal float m14;
	internal float m15;
}
[StructLayout(LayoutKind.Sequential)] internal struct HmdVector3_t
{
	internal float v0; //float[3]
	internal float v1;
	internal float v2;
}
[StructLayout(LayoutKind.Sequential)] internal struct HmdVector4_t
{
	internal float v0; //float[4]
	internal float v1;
	internal float v2;
	internal float v3;
}
[StructLayout(LayoutKind.Sequential)] internal struct HmdVector3d_t
{
	internal double v0; //double[3]
	internal double v1;
	internal double v2;
}
[StructLayout(LayoutKind.Sequential)] internal struct HmdVector2_t
{
	internal float v0; //float[2]
	internal float v1;
}
[StructLayout(LayoutKind.Sequential)] internal struct HmdQuaternion_t
{
	internal double w;
	internal double x;
	internal double y;
	internal double z;
}
[StructLayout(LayoutKind.Sequential)] internal struct HmdColor_t
{
	internal float r;
	internal float g;
	internal float b;
	internal float a;
}
[StructLayout(LayoutKind.Sequential)] internal struct HmdQuad_t
{
	internal HmdVector3_t vCorners0; //HmdVector3_t[4]
	internal HmdVector3_t vCorners1;
	internal HmdVector3_t vCorners2;
	internal HmdVector3_t vCorners3;
}
[StructLayout(LayoutKind.Sequential)] internal struct HmdRect2_t
{
	internal HmdVector2_t vTopLeft;
	internal HmdVector2_t vBottomRight;
}
[StructLayout(LayoutKind.Sequential)] internal struct DistortionCoordinates_t
{
	internal float rfRed0; //float[2]
	internal float rfRed1;
	internal float rfGreen0; //float[2]
	internal float rfGreen1;
	internal float rfBlue0; //float[2]
	internal float rfBlue1;
}
[StructLayout(LayoutKind.Sequential)] internal struct Texture_t
{
	internal IntPtr handle; // void *
	internal EGraphicsAPIConvention eType;
	internal EColorSpace eColorSpace;
}
[StructLayout(LayoutKind.Sequential)] internal struct TrackedDevicePose_t
{
	internal HmdMatrix34_t mDeviceToAbsoluteTracking;
	internal HmdVector3_t vVelocity;
	internal HmdVector3_t vAngularVelocity;
	internal ETrackingResult eTrackingResult;
	[MarshalAs(UnmanagedType.I1)]
	internal bool bPoseIsValid;
	[MarshalAs(UnmanagedType.I1)]
	internal bool bDeviceIsConnected;
}
[StructLayout(LayoutKind.Sequential)] internal struct VRTextureBounds_t
{
	internal float uMin;
	internal float vMin;
	internal float uMax;
	internal float vMax;
}
[StructLayout(LayoutKind.Sequential)] internal struct VulkanData_t
{
	internal ulong m_nImage;
	internal IntPtr m_pDevice; // struct VkDevice_T *
	internal IntPtr m_pPhysicalDevice; // struct VkPhysicalDevice_T *
	internal IntPtr m_pInstance; // struct VkInstance_T *
	internal IntPtr m_pQueue; // struct VkQueue_T *
	internal uint m_nQueueFamilyIndex;
	internal uint m_nWidth;
	internal uint m_nHeight;
	internal uint m_nFormat;
	internal uint m_nSampleCount;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_Controller_t
{
	internal uint button;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_Mouse_t
{
	internal float x;
	internal float y;
	internal uint button;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_Scroll_t
{
	internal float xdelta;
	internal float ydelta;
	internal uint repeatCount;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_TouchPadMove_t
{
	[MarshalAs(UnmanagedType.I1)]
	internal bool bFingerDown;
	internal float flSecondsFingerDown;
	internal float fValueXFirst;
	internal float fValueYFirst;
	internal float fValueXRaw;
	internal float fValueYRaw;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_Notification_t
{
	internal ulong ulUserValue;
	internal uint notificationId;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_Process_t
{
	internal uint pid;
	internal uint oldPid;
	[MarshalAs(UnmanagedType.I1)]
	internal bool bForced;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_Overlay_t
{
	internal ulong overlayHandle;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_Status_t
{
	internal uint statusState;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_Keyboard_t
{
	internal byte cNewInput0,cNewInput1,cNewInput2,cNewInput3,cNewInput4,cNewInput5,cNewInput6,cNewInput7;
	internal ulong uUserValue;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_Ipd_t
{
	internal float ipdMeters;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_Chaperone_t
{
	internal ulong m_nPreviousUniverse;
	internal ulong m_nCurrentUniverse;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_Reserved_t
{
	internal ulong reserved0;
	internal ulong reserved1;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_PerformanceTest_t
{
	internal uint m_nFidelityLevel;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_SeatedZeroPoseReset_t
{
	[MarshalAs(UnmanagedType.I1)]
	internal bool bResetBySystemMenu;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_Screenshot_t
{
	internal uint handle;
	internal uint type;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_ScreenshotProgress_t
{
	internal float progress;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_ApplicationLaunch_t
{
	internal uint pid;
	internal uint unArgsHandle;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_EditingCameraSurface_t
{
	internal ulong overlayHandle;
	internal uint nVisualMode;
}
[StructLayout(LayoutKind.Sequential)] internal struct VREvent_t
{
	internal uint eventType;
	internal uint trackedDeviceIndex;
	internal float eventAgeSeconds;
	internal VREvent_Data_t data;
}
[StructLayout(LayoutKind.Sequential)] internal struct HiddenAreaMesh_t
{
	internal IntPtr pVertexData; // const struct vr::HmdVector2_t *
	internal uint unTriangleCount;
}
[StructLayout(LayoutKind.Sequential)] internal struct VRControllerAxis_t
{
	internal float x;
	internal float y;
}
[StructLayout(LayoutKind.Sequential)] internal struct VRControllerState_t
{
	internal uint unPacketNum;
	internal ulong ulButtonPressed;
	internal ulong ulButtonTouched;
	internal VRControllerAxis_t rAxis0; //VRControllerAxis_t[5]
	internal VRControllerAxis_t rAxis1;
	internal VRControllerAxis_t rAxis2;
	internal VRControllerAxis_t rAxis3;
	internal VRControllerAxis_t rAxis4;
}
[StructLayout(LayoutKind.Sequential)] internal struct Compositor_OverlaySettings
{
	internal uint size;
	[MarshalAs(UnmanagedType.I1)]
	internal bool curved;
	[MarshalAs(UnmanagedType.I1)]
	internal bool antialias;
	internal float scale;
	internal float distance;
	internal float alpha;
	internal float uOffset;
	internal float vOffset;
	internal float uScale;
	internal float vScale;
	internal float gridDivs;
	internal float gridWidth;
	internal float gridScale;
	internal HmdMatrix44_t transform;
}
[StructLayout(LayoutKind.Sequential)] internal struct CameraVideoStreamFrameHeader_t
{
	internal EVRTrackedCameraFrameType eFrameType;
	internal uint nWidth;
	internal uint nHeight;
	internal uint nBytesPerPixel;
	internal uint nFrameSequence;
	internal TrackedDevicePose_t standingTrackedDevicePose;
}
[StructLayout(LayoutKind.Sequential)] internal struct AppOverrideKeys_t
{
	internal IntPtr pchKey; // const char *
	internal IntPtr pchValue; // const char *
}
[StructLayout(LayoutKind.Sequential)] internal struct Compositor_FrameTiming
{
	internal uint m_nSize;
	internal uint m_nFrameIndex;
	internal uint m_nNumFramePresents;
	internal uint m_nNumMisPresented;
	internal uint m_nNumDroppedFrames;
	internal uint m_nReprojectionFlags;
	internal double m_flSystemTimeInSeconds;
	internal float m_flPreSubmitGpuMs;
	internal float m_flPostSubmitGpuMs;
	internal float m_flTotalRenderGpuMs;
	internal float m_flCompositorRenderGpuMs;
	internal float m_flCompositorRenderCpuMs;
	internal float m_flCompositorIdleCpuMs;
	internal float m_flClientFrameIntervalMs;
	internal float m_flPresentCallCpuMs;
	internal float m_flWaitForPresentCpuMs;
	internal float m_flSubmitFrameMs;
	internal float m_flWaitGetPosesCalledMs;
	internal float m_flNewPosesReadyMs;
	internal float m_flNewFrameReadyMs;
	internal float m_flCompositorUpdateStartMs;
	internal float m_flCompositorUpdateEndMs;
	internal float m_flCompositorRenderStartMs;
	internal TrackedDevicePose_t m_HmdPose;
}
[StructLayout(LayoutKind.Sequential)] internal struct Compositor_CumulativeStats
{
	internal uint m_nPid;
	internal uint m_nNumFramePresents;
	internal uint m_nNumDroppedFrames;
	internal uint m_nNumReprojectedFrames;
	internal uint m_nNumFramePresentsOnStartup;
	internal uint m_nNumDroppedFramesOnStartup;
	internal uint m_nNumReprojectedFramesOnStartup;
	internal uint m_nNumLoading;
	internal uint m_nNumFramePresentsLoading;
	internal uint m_nNumDroppedFramesLoading;
	internal uint m_nNumReprojectedFramesLoading;
	internal uint m_nNumTimedOut;
	internal uint m_nNumFramePresentsTimedOut;
	internal uint m_nNumDroppedFramesTimedOut;
	internal uint m_nNumReprojectedFramesTimedOut;
}
[StructLayout(LayoutKind.Sequential)] internal struct VROverlayIntersectionParams_t
{
	internal HmdVector3_t vSource;
	internal HmdVector3_t vDirection;
	internal ETrackingUniverseOrigin eOrigin;
}
[StructLayout(LayoutKind.Sequential)] internal struct VROverlayIntersectionResults_t
{
	internal HmdVector3_t vPoint;
	internal HmdVector3_t vNormal;
	internal HmdVector2_t vUVs;
	internal float fDistance;
}
[StructLayout(LayoutKind.Sequential)] internal struct IntersectionMaskRectangle_t
{
	internal float m_flTopLeftX;
	internal float m_flTopLeftY;
	internal float m_flWidth;
	internal float m_flHeight;
}
[StructLayout(LayoutKind.Sequential)] internal struct IntersectionMaskCircle_t
{
	internal float m_flCenterX;
	internal float m_flCenterY;
	internal float m_flRadius;
}
[StructLayout(LayoutKind.Sequential)] internal struct VROverlayIntersectionMaskPrimitive_t
{
	internal EVROverlayIntersectionMaskPrimitiveType m_nPrimitiveType;
	internal VROverlayIntersectionMaskPrimitive_Data_t m_Primitive;
}
[StructLayout(LayoutKind.Sequential)] internal struct RenderModel_ComponentState_t
{
	internal HmdMatrix34_t mTrackingToComponentRenderModel;
	internal HmdMatrix34_t mTrackingToComponentLocal;
	internal uint uProperties;
}
[StructLayout(LayoutKind.Sequential)] internal struct RenderModel_Vertex_t
{
	internal HmdVector3_t vPosition;
	internal HmdVector3_t vNormal;
	internal float rfTextureCoord0; //float[2]
	internal float rfTextureCoord1;
}
[StructLayout(LayoutKind.Sequential)] internal struct RenderModel_TextureMap_t
{
	internal char unWidth;
	internal char unHeight;
	internal IntPtr rubTextureMapData; // const uint8_t *
}
[StructLayout(LayoutKind.Sequential)] internal struct RenderModel_t
{
	internal IntPtr rVertexData; // const struct vr::RenderModel_Vertex_t *
	internal uint unVertexCount;
	internal IntPtr rIndexData; // const uint16_t *
	internal uint unTriangleCount;
	internal int diffuseTextureId;
}
[StructLayout(LayoutKind.Sequential)] internal struct RenderModel_ControllerMode_State_t
{
	[MarshalAs(UnmanagedType.I1)]
	internal bool bScrollWheelVisible;
}
[StructLayout(LayoutKind.Sequential)] internal struct NotificationBitmap_t
{
	internal IntPtr m_pImageData; // void *
	internal int m_nWidth;
	internal int m_nHeight;
	internal int m_nBytesPerPixel;
}
[StructLayout(LayoutKind.Sequential)] internal struct COpenVRContext
{
	internal IntPtr m_pVRSystem; // class vr::IVRSystem *
	internal IntPtr m_pVRChaperone; // class vr::IVRChaperone *
	internal IntPtr m_pVRChaperoneSetup; // class vr::IVRChaperoneSetup *
	internal IntPtr m_pVRCompositor; // class vr::IVRCompositor *
	internal IntPtr m_pVROverlay; // class vr::IVROverlay *
	internal IntPtr m_pVRResources; // class vr::IVRResources *
	internal IntPtr m_pVRRenderModels; // class vr::IVRRenderModels *
	internal IntPtr m_pVRExtendedDisplay; // class vr::IVRExtendedDisplay *
	internal IntPtr m_pVRSettings; // class vr::IVRSettings *
	internal IntPtr m_pVRApplications; // class vr::IVRApplications *
	internal IntPtr m_pVRTrackedCamera; // class vr::IVRTrackedCamera *
	internal IntPtr m_pVRScreenshots; // class vr::IVRScreenshots *
}

internal class OpenVR
{

	internal static uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType)
	{
		return OpenVRInterop.InitInternal(ref peError, eApplicationType);
	}

	internal static void ShutdownInternal()
	{
		OpenVRInterop.ShutdownInternal();
	}

	internal static bool IsHmdPresent()
	{
		return OpenVRInterop.IsHmdPresent();
	}

	internal static bool IsRuntimeInstalled()
	{
		return OpenVRInterop.IsRuntimeInstalled();
	}

	internal static string GetStringForHmdError(EVRInitError error)
	{
		return Marshal.PtrToStringAnsi(OpenVRInterop.GetStringForHmdError(error));
	}

	internal static IntPtr GetGenericInterface(string pchInterfaceVersion, ref EVRInitError peError)
	{
		return OpenVRInterop.GetGenericInterface(pchInterfaceVersion, ref peError);
	}

	internal static bool IsInterfaceVersionValid(string pchInterfaceVersion)
	{
		return OpenVRInterop.IsInterfaceVersionValid(pchInterfaceVersion);
	}

	internal static uint GetInitToken()
	{
		return OpenVRInterop.GetInitToken();
	}

	internal const uint k_unMaxDriverDebugResponseSize = 32768;
	internal const uint k_unTrackedDeviceIndex_Hmd = 0;
	internal const uint k_unMaxTrackedDeviceCount = 16;
	internal const uint k_unTrackedDeviceIndexOther = 4294967294;
	internal const uint k_unTrackedDeviceIndexInvalid = 4294967295;
	internal const uint k_unMaxPropertyStringSize = 32768;
	internal const uint k_unControllerStateAxisCount = 5;
	internal const ulong k_ulOverlayHandleInvalid = 0;
	internal const uint k_unScreenshotHandleInvalid = 0;
	internal const string IVRSystem_Version = "IVRSystem_014";
	internal const string IVRExtendedDisplay_Version = "IVRExtendedDisplay_001";
	internal const string IVRTrackedCamera_Version = "IVRTrackedCamera_003";
	internal const uint k_unMaxApplicationKeyLength = 128;
	internal const string k_pch_MimeType_HomeApp = "vr/home";
	internal const string k_pch_MimeType_GameTheater = "vr/game_theater";
	internal const string IVRApplications_Version = "IVRApplications_006";
	internal const string IVRChaperone_Version = "IVRChaperone_003";
	internal const string IVRChaperoneSetup_Version = "IVRChaperoneSetup_005";
	internal const string IVRCompositor_Version = "IVRCompositor_018";
	internal const uint k_unVROverlayMaxKeyLength = 128;
	internal const uint k_unVROverlayMaxNameLength = 128;
	internal const uint k_unMaxOverlayCount = 64;
	internal const uint k_unMaxOverlayIntersectionMaskPrimitivesCount = 32;
	internal const string IVROverlay_Version = "IVROverlay_013";
	internal const string k_pch_Controller_Component_GDC2015 = "gdc2015";
	internal const string k_pch_Controller_Component_Base = "base";
	internal const string k_pch_Controller_Component_Tip = "tip";
	internal const string k_pch_Controller_Component_HandGrip = "handgrip";
	internal const string k_pch_Controller_Component_Status = "status";
	internal const string IVRRenderModels_Version = "IVRRenderModels_005";
	internal const uint k_unNotificationTextMaxSize = 256;
	internal const string IVRNotifications_Version = "IVRNotifications_002";
	internal const uint k_unMaxSettingsKeyLength = 128;
	internal const string IVRSettings_Version = "IVRSettings_002";
	internal const string k_pch_SteamVR_Section = "steamvr";
	internal const string k_pch_SteamVR_RequireHmd_String = "requireHmd";
	internal const string k_pch_SteamVR_ForcedDriverKey_String = "forcedDriver";
	internal const string k_pch_SteamVR_ForcedHmdKey_String = "forcedHmd";
	internal const string k_pch_SteamVR_DisplayDebug_Bool = "displayDebug";
	internal const string k_pch_SteamVR_DebugProcessPipe_String = "debugProcessPipe";
	internal const string k_pch_SteamVR_EnableDistortion_Bool = "enableDistortion";
	internal const string k_pch_SteamVR_DisplayDebugX_Int32 = "displayDebugX";
	internal const string k_pch_SteamVR_DisplayDebugY_Int32 = "displayDebugY";
	internal const string k_pch_SteamVR_SendSystemButtonToAllApps_Bool = "sendSystemButtonToAllApps";
	internal const string k_pch_SteamVR_LogLevel_Int32 = "loglevel";
	internal const string k_pch_SteamVR_IPD_Float = "ipd";
	internal const string k_pch_SteamVR_Background_String = "background";
	internal const string k_pch_SteamVR_BackgroundUseDomeProjection_Bool = "backgroundUseDomeProjection";
	internal const string k_pch_SteamVR_BackgroundCameraHeight_Float = "backgroundCameraHeight";
	internal const string k_pch_SteamVR_BackgroundDomeRadius_Float = "backgroundDomeRadius";
	internal const string k_pch_SteamVR_GridColor_String = "gridColor";
	internal const string k_pch_SteamVR_PlayAreaColor_String = "playAreaColor";
	internal const string k_pch_SteamVR_ShowStage_Bool = "showStage";
	internal const string k_pch_SteamVR_ActivateMultipleDrivers_Bool = "activateMultipleDrivers";
	internal const string k_pch_SteamVR_DirectMode_Bool = "directMode";
	internal const string k_pch_SteamVR_DirectModeEdidVid_Int32 = "directModeEdidVid";
	internal const string k_pch_SteamVR_DirectModeEdidPid_Int32 = "directModeEdidPid";
	internal const string k_pch_SteamVR_UsingSpeakers_Bool = "usingSpeakers";
	internal const string k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float = "speakersForwardYawOffsetDegrees";
	internal const string k_pch_SteamVR_BaseStationPowerManagement_Bool = "basestationPowerManagement";
	internal const string k_pch_SteamVR_NeverKillProcesses_Bool = "neverKillProcesses";
	internal const string k_pch_SteamVR_RenderTargetMultiplier_Float = "renderTargetMultiplier";
	internal const string k_pch_SteamVR_AllowAsyncReprojection_Bool = "allowAsyncReprojection";
	internal const string k_pch_SteamVR_AllowReprojection_Bool = "allowInterleavedReprojection";
	internal const string k_pch_SteamVR_ForceReprojection_Bool = "forceReprojection";
	internal const string k_pch_SteamVR_ForceFadeOnBadTracking_Bool = "forceFadeOnBadTracking";
	internal const string k_pch_SteamVR_DefaultMirrorView_Int32 = "defaultMirrorView";
	internal const string k_pch_SteamVR_ShowMirrorView_Bool = "showMirrorView";
	internal const string k_pch_SteamVR_MirrorViewGeometry_String = "mirrorViewGeometry";
	internal const string k_pch_SteamVR_StartMonitorFromAppLaunch = "startMonitorFromAppLaunch";
	internal const string k_pch_SteamVR_EnableHomeApp = "enableHomeApp";
	internal const string k_pch_SteamVR_SetInitialDefaultHomeApp = "setInitialDefaultHomeApp";
	internal const string k_pch_SteamVR_CycleBackgroundImageTimeSec_Int32 = "CycleBackgroundImageTimeSec";
	internal const string k_pch_SteamVR_RetailDemo_Bool = "retailDemo";
	internal const string k_pch_SteamVR_IpdOffset_Float = "ipdOffset";
	internal const string k_pch_Lighthouse_Section = "driver_lighthouse";
	internal const string k_pch_Lighthouse_DisableIMU_Bool = "disableimu";
	internal const string k_pch_Lighthouse_UseDisambiguation_String = "usedisambiguation";
	internal const string k_pch_Lighthouse_DisambiguationDebug_Int32 = "disambiguationdebug";
	internal const string k_pch_Lighthouse_PrimaryBasestation_Int32 = "primarybasestation";
	internal const string k_pch_Lighthouse_DBHistory_Bool = "dbhistory";
	internal const string k_pch_Null_Section = "driver_null";
	internal const string k_pch_Null_EnableNullDriver_Bool = "enable";
	internal const string k_pch_Null_SerialNumber_String = "serialNumber";
	internal const string k_pch_Null_ModelNumber_String = "modelNumber";
	internal const string k_pch_Null_WindowX_Int32 = "windowX";
	internal const string k_pch_Null_WindowY_Int32 = "windowY";
	internal const string k_pch_Null_WindowWidth_Int32 = "windowWidth";
	internal const string k_pch_Null_WindowHeight_Int32 = "windowHeight";
	internal const string k_pch_Null_RenderWidth_Int32 = "renderWidth";
	internal const string k_pch_Null_RenderHeight_Int32 = "renderHeight";
	internal const string k_pch_Null_SecondsFromVsyncToPhotons_Float = "secondsFromVsyncToPhotons";
	internal const string k_pch_Null_DisplayFrequency_Float = "displayFrequency";
	internal const string k_pch_UserInterface_Section = "userinterface";
	internal const string k_pch_UserInterface_StatusAlwaysOnTop_Bool = "StatusAlwaysOnTop";
	internal const string k_pch_UserInterface_MinimizeToTray_Bool = "MinimizeToTray";
	internal const string k_pch_UserInterface_Screenshots_Bool = "screenshots";
	internal const string k_pch_UserInterface_ScreenshotType_Int = "screenshotType";
	internal const string k_pch_Notifications_Section = "notifications";
	internal const string k_pch_Notifications_DoNotDisturb_Bool = "DoNotDisturb";
	internal const string k_pch_Keyboard_Section = "keyboard";
	internal const string k_pch_Keyboard_TutorialCompletions = "TutorialCompletions";
	internal const string k_pch_Keyboard_ScaleX = "ScaleX";
	internal const string k_pch_Keyboard_ScaleY = "ScaleY";
	internal const string k_pch_Keyboard_OffsetLeftX = "OffsetLeftX";
	internal const string k_pch_Keyboard_OffsetRightX = "OffsetRightX";
	internal const string k_pch_Keyboard_OffsetY = "OffsetY";
	internal const string k_pch_Keyboard_Smoothing = "Smoothing";
	internal const string k_pch_Perf_Section = "perfcheck";
	internal const string k_pch_Perf_HeuristicActive_Bool = "heuristicActive";
	internal const string k_pch_Perf_NotifyInHMD_Bool = "warnInHMD";
	internal const string k_pch_Perf_NotifyOnlyOnce_Bool = "warnOnlyOnce";
	internal const string k_pch_Perf_AllowTimingStore_Bool = "allowTimingStore";
	internal const string k_pch_Perf_SaveTimingsOnExit_Bool = "saveTimingsOnExit";
	internal const string k_pch_Perf_TestData_Float = "perfTestData";
	internal const string k_pch_CollisionBounds_Section = "collisionBounds";
	internal const string k_pch_CollisionBounds_Style_Int32 = "CollisionBoundsStyle";
	internal const string k_pch_CollisionBounds_GroundPerimeterOn_Bool = "CollisionBoundsGroundPerimeterOn";
	internal const string k_pch_CollisionBounds_CenterMarkerOn_Bool = "CollisionBoundsCenterMarkerOn";
	internal const string k_pch_CollisionBounds_PlaySpaceOn_Bool = "CollisionBoundsPlaySpaceOn";
	internal const string k_pch_CollisionBounds_FadeDistance_Float = "CollisionBoundsFadeDistance";
	internal const string k_pch_CollisionBounds_ColorGammaR_Int32 = "CollisionBoundsColorGammaR";
	internal const string k_pch_CollisionBounds_ColorGammaG_Int32 = "CollisionBoundsColorGammaG";
	internal const string k_pch_CollisionBounds_ColorGammaB_Int32 = "CollisionBoundsColorGammaB";
	internal const string k_pch_CollisionBounds_ColorGammaA_Int32 = "CollisionBoundsColorGammaA";
	internal const string k_pch_Camera_Section = "camera";
	internal const string k_pch_Camera_EnableCamera_Bool = "enableCamera";
	internal const string k_pch_Camera_EnableCameraInDashboard_Bool = "enableCameraInDashboard";
	internal const string k_pch_Camera_EnableCameraForCollisionBounds_Bool = "enableCameraForCollisionBounds";
	internal const string k_pch_Camera_EnableCameraForRoomView_Bool = "enableCameraForRoomView";
	internal const string k_pch_Camera_BoundsColorGammaR_Int32 = "cameraBoundsColorGammaR";
	internal const string k_pch_Camera_BoundsColorGammaG_Int32 = "cameraBoundsColorGammaG";
	internal const string k_pch_Camera_BoundsColorGammaB_Int32 = "cameraBoundsColorGammaB";
	internal const string k_pch_Camera_BoundsColorGammaA_Int32 = "cameraBoundsColorGammaA";
	internal const string k_pch_Camera_BoundsStrength_Int32 = "cameraBoundsStrength";
	internal const string k_pch_audio_Section = "audio";
	internal const string k_pch_audio_OnPlaybackDevice_String = "onPlaybackDevice";
	internal const string k_pch_audio_OnRecordDevice_String = "onRecordDevice";
	internal const string k_pch_audio_OnPlaybackMirrorDevice_String = "onPlaybackMirrorDevice";
	internal const string k_pch_audio_OffPlaybackDevice_String = "offPlaybackDevice";
	internal const string k_pch_audio_OffRecordDevice_String = "offRecordDevice";
	internal const string k_pch_audio_VIVEHDMIGain = "viveHDMIGain";
	internal const string k_pch_Power_Section = "power";
	internal const string k_pch_Power_PowerOffOnExit_Bool = "powerOffOnExit";
	internal const string k_pch_Power_TurnOffScreensTimeout_Float = "turnOffScreensTimeout";
	internal const string k_pch_Power_TurnOffControllersTimeout_Float = "turnOffControllersTimeout";
	internal const string k_pch_Power_ReturnToWatchdogTimeout_Float = "returnToWatchdogTimeout";
	internal const string k_pch_Power_AutoLaunchSteamVROnButtonPress = "autoLaunchSteamVROnButtonPress";
	internal const string k_pch_Dashboard_Section = "dashboard";
	internal const string k_pch_Dashboard_EnableDashboard_Bool = "enableDashboard";
	internal const string k_pch_Dashboard_ArcadeMode_Bool = "arcadeMode";
	internal const string k_pch_modelskin_Section = "modelskins";
	internal const string IVRScreenshots_Version = "IVRScreenshots_001";
	internal const string IVRResources_Version = "IVRResources_001";

	static uint VRToken { get; set; }

	const string FnTable_Prefix = "FnTable:";

	class COpenVRContext
	{
		internal COpenVRContext() { Clear(); }

		internal void Clear()
		{
			m_pVRSystem = null;
			m_pVRChaperone = null;
			m_pVRChaperoneSetup = null;
			m_pVRCompositor = null;
			m_pVROverlay = null;
			m_pVRRenderModels = null;
			m_pVRExtendedDisplay = null;
			m_pVRSettings = null;
			m_pVRApplications = null;
			m_pVRScreenshots = null;
			m_pVRTrackedCamera = null;
		}

		void CheckClear()
		{
			if (VRToken != GetInitToken())
			{
				Clear();
				VRToken = GetInitToken();
			}
		}

		internal CVRSystem VRSystem()
		{
			CheckClear();
			if (m_pVRSystem == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRSystem_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRSystem = new CVRSystem(pInterface);
			}
			return m_pVRSystem;
		}

		internal CVRChaperone VRChaperone()
		{
			CheckClear();
			if (m_pVRChaperone == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRChaperone_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRChaperone = new CVRChaperone(pInterface);
			}
			return m_pVRChaperone;
		}

		internal CVRChaperoneSetup VRChaperoneSetup()
		{
			CheckClear();
			if (m_pVRChaperoneSetup == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRChaperoneSetup_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRChaperoneSetup = new CVRChaperoneSetup(pInterface);
			}
			return m_pVRChaperoneSetup;
		}

		internal CVRCompositor VRCompositor()
		{
			CheckClear();
			if (m_pVRCompositor == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRCompositor_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRCompositor = new CVRCompositor(pInterface);
			}
			return m_pVRCompositor;
		}

		internal CVROverlay VROverlay()
		{
			CheckClear();
			if (m_pVROverlay == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVROverlay_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVROverlay = new CVROverlay(pInterface);
			}
			return m_pVROverlay;
		}

		internal CVRRenderModels VRRenderModels()
		{
			CheckClear();
			if (m_pVRRenderModels == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRRenderModels_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRRenderModels = new CVRRenderModels(pInterface);
			}
			return m_pVRRenderModels;
		}

		internal CVRExtendedDisplay VRExtendedDisplay()
		{
			CheckClear();
			if (m_pVRExtendedDisplay == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRExtendedDisplay_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRExtendedDisplay = new CVRExtendedDisplay(pInterface);
			}
			return m_pVRExtendedDisplay;
		}

		internal CVRSettings VRSettings()
		{
			CheckClear();
			if (m_pVRSettings == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRSettings_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRSettings = new CVRSettings(pInterface);
			}
			return m_pVRSettings;
		}

		internal CVRApplications VRApplications()
		{
			CheckClear();
			if (m_pVRApplications == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRApplications_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRApplications = new CVRApplications(pInterface);
			}
			return m_pVRApplications;
		}

		internal CVRScreenshots VRScreenshots()
		{
			CheckClear();
			if (m_pVRScreenshots == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRScreenshots_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRScreenshots = new CVRScreenshots(pInterface);
			}
			return m_pVRScreenshots;
		}

		internal CVRTrackedCamera VRTrackedCamera()
		{
			CheckClear();
			if (m_pVRTrackedCamera == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRTrackedCamera_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRTrackedCamera = new CVRTrackedCamera(pInterface);
			}
			return m_pVRTrackedCamera;
		}

		private CVRSystem m_pVRSystem;
		private CVRChaperone m_pVRChaperone;
		private CVRChaperoneSetup m_pVRChaperoneSetup;
		private CVRCompositor m_pVRCompositor;
		private CVROverlay m_pVROverlay;
		private CVRRenderModels m_pVRRenderModels;
		private CVRExtendedDisplay m_pVRExtendedDisplay;
		private CVRSettings m_pVRSettings;
		private CVRApplications m_pVRApplications;
		private CVRScreenshots m_pVRScreenshots;
		private CVRTrackedCamera m_pVRTrackedCamera;
	};

	private static COpenVRContext _OpenVRInternal_ModuleContext = null;
	static COpenVRContext OpenVRInternal_ModuleContext
	{
		get
		{
			if (_OpenVRInternal_ModuleContext == null)
				_OpenVRInternal_ModuleContext = new COpenVRContext();
			return _OpenVRInternal_ModuleContext;
		}
	}

	internal static CVRSystem System { get { return OpenVRInternal_ModuleContext.VRSystem(); } }
	internal static CVRChaperone Chaperone { get { return OpenVRInternal_ModuleContext.VRChaperone(); } }
	internal static CVRChaperoneSetup ChaperoneSetup { get { return OpenVRInternal_ModuleContext.VRChaperoneSetup(); } }
	internal static CVRCompositor Compositor { get { return OpenVRInternal_ModuleContext.VRCompositor(); } }
	internal static CVROverlay Overlay { get { return OpenVRInternal_ModuleContext.VROverlay(); } }
	internal static CVRRenderModels RenderModels { get { return OpenVRInternal_ModuleContext.VRRenderModels(); } }
	internal static CVRExtendedDisplay ExtendedDisplay { get { return OpenVRInternal_ModuleContext.VRExtendedDisplay(); } }
	internal static CVRSettings Settings { get { return OpenVRInternal_ModuleContext.VRSettings(); } }
	internal static CVRApplications Applications { get { return OpenVRInternal_ModuleContext.VRApplications(); } }
	internal static CVRScreenshots Screenshots { get { return OpenVRInternal_ModuleContext.VRScreenshots(); } }
	internal static CVRTrackedCamera TrackedCamera { get { return OpenVRInternal_ModuleContext.VRTrackedCamera(); } }

	/** Finds the active installation of vrclient.dll and initializes it */
	internal static CVRSystem Init(ref EVRInitError peError, EVRApplicationType eApplicationType = EVRApplicationType.VRApplication_Scene)
	{
		VRToken = InitInternal(ref peError, eApplicationType);
		OpenVRInternal_ModuleContext.Clear();

		if (peError != EVRInitError.None)
			return null;

		bool bInterfaceValid = IsInterfaceVersionValid(IVRSystem_Version);
		if (!bInterfaceValid)
		{
			ShutdownInternal();
			peError = EVRInitError.Init_InterfaceNotFound;
			return null;
		}

		return OpenVR.System;
	}

	/** unloads vrclient.dll. Any interface pointers from the interface are
	* invalid after this point */
	internal static void Shutdown()
	{
		ShutdownInternal();
	}

}



}

