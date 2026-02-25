using System;
using System.Runtime.CompilerServices;
using Core.Net.Connection;
using Core.Net.Monitor.Responseability;
using Il2CppDummyDll;
using UI.Informer;
using UI.Windows;

namespace Core.Application.Managers.Connection
{
	// Token: 0x02001263 RID: 4707
	[Token(Token = "0x2001263")]
	public class ConnectionInformer : IDisposable
	{
		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06006F91 RID: 28561 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F92 RID: 28562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016C4")]
		public ISystemDisconnectResolver DisconnectResolver
		{
			[Token(Token = "0x6006F91")]
			[Address(RVA = "0xB9F2", Offset = "0xB9F2", VA = "0xB9F2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F92")]
			[Address(RVA = "0xB9F3", Offset = "0xB9F3", VA = "0xB9F3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006F93 RID: 28563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F93")]
		[Address(RVA = "0xB9F4", Offset = "0xB9F4", VA = "0xB9F4", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06006F94 RID: 28564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F94")]
		[Address(RVA = "0xB9F5", Offset = "0xB9F5", VA = "0xB9F5")]
		public ConnectionInformer(float connectTimeoutToWarning, InformerView appCanvasInformerView, ILowResponseAbilityMonitor lowResponseAbilityMonitor, ISystemDisconnectResolver disconnectResolver)
		{
		}

		// Token: 0x06006F95 RID: 28565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F95")]
		[Address(RVA = "0xB9F6", Offset = "0xB9F6", VA = "0xB9F6")]
		public void SetState(ConnectionState state)
		{
		}

		// Token: 0x06006F96 RID: 28566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F96")]
		[Address(RVA = "0xB9F7", Offset = "0xB9F7", VA = "0xB9F7")]
		private void HandleResponseAbilityChangedEvent(ResponseAbilityStatus status)
		{
		}

		// Token: 0x06006F97 RID: 28567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F97")]
		[Address(RVA = "0xB9F8", Offset = "0xB9F8", VA = "0xB9F8")]
		private void HandleResponseTimeExceededEvent(bool value)
		{
		}

		// Token: 0x06006F98 RID: 28568 RVA: 0x000144C0 File Offset: 0x000126C0
		[Token(Token = "0x6006F98")]
		[Address(RVA = "0xB9F9", Offset = "0xB9F9", VA = "0xB9F9")]
		public bool TryNotifyServerReadyToStop()
		{
			return default(bool);
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06006F99 RID: 28569 RVA: 0x000144D8 File Offset: 0x000126D8
		// (set) Token: 0x06006F9A RID: 28570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016C5")]
		private float _awaitToWarningExpireTime
		{
			[Token(Token = "0x6006F99")]
			[Address(RVA = "0xB9FA", Offset = "0xB9FA", VA = "0xB9FA")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006F9A")]
			[Address(RVA = "0xB9FB", Offset = "0xB9FB", VA = "0xB9FB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F9B")]
		[Address(RVA = "0xB9FC", Offset = "0xB9FC", VA = "0xB9FC")]
		private void ShowServerMaintenanceWindow()
		{
		}

		// Token: 0x04003A45 RID: 14917
		[Token(Token = "0x4003A45")]
		[FieldOffset(Offset = "0xC")]
		public readonly float ConnectTimeoutToWarning;

		// Token: 0x04003A46 RID: 14918
		[Token(Token = "0x4003A46")]
		[FieldOffset(Offset = "0x10")]
		private InformerView _appCanvasInformerView;

		// Token: 0x04003A47 RID: 14919
		[Token(Token = "0x4003A47")]
		[FieldOffset(Offset = "0x14")]
		private ILowResponseAbilityMonitor _lowResponseAbilityMonitor;

		// Token: 0x04003A48 RID: 14920
		[Token(Token = "0x4003A48")]
		[FieldOffset(Offset = "0x18")]
		private ConnectionState _state;

		// Token: 0x04003A49 RID: 14921
		[Token(Token = "0x4003A49")]
		[FieldOffset(Offset = "0x1C")]
		private DialogWindow _serverReadyToStopDialogWindow;

		// Token: 0x04003A4B RID: 14923
		[Token(Token = "0x4003A4B")]
		[FieldOffset(Offset = "0x24")]
		private DialogWindow _connectTimeoutOverWarningDialogWindow;
	}
}
