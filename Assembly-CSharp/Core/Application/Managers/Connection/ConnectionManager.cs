using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core.Net.Connection;
using Core.Net.Monitor.Responseability;
using Il2CppDummyDll;
using Protocol.System;

namespace Core.Application.Managers.Connection
{
	// Token: 0x02001264 RID: 4708
	[Token(Token = "0x2001264")]
	public class ConnectionManager : IAppManager, IBaseManager, IConnectionManage
	{
		// Token: 0x140002F5 RID: 757
		// (add) Token: 0x06006F9E RID: 28574 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F9F RID: 28575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F5")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F9E")]
			[Address(RVA = "0xB9FF", Offset = "0xB9FF", VA = "0xB9FF", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F9F")]
			[Address(RVA = "0xBA00", Offset = "0xBA00", VA = "0xBA00", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002F6 RID: 758
		// (add) Token: 0x06006FA0 RID: 28576 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006FA1 RID: 28577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F6")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006FA0")]
			[Address(RVA = "0xBA01", Offset = "0xBA01", VA = "0xBA01", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006FA1")]
			[Address(RVA = "0xBA02", Offset = "0xBA02", VA = "0xBA02", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06006FA2 RID: 28578 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016C6")]
		public string Name
		{
			[Token(Token = "0x6006FA2")]
			[Address(RVA = "0xBA03", Offset = "0xBA03", VA = "0xBA03", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06006FA3 RID: 28579 RVA: 0x000144F0 File Offset: 0x000126F0
		// (set) Token: 0x06006FA4 RID: 28580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016C7")]
		private int ConnectionOpenedCount
		{
			[Token(Token = "0x6006FA3")]
			[Address(RVA = "0xBA04", Offset = "0xBA04", VA = "0xBA04")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006FA4")]
			[Address(RVA = "0xBA05", Offset = "0xBA05", VA = "0xBA05")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06006FA5 RID: 28581 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016C8")]
		public IPing Ping
		{
			[Token(Token = "0x6006FA5")]
			[Address(RVA = "0xBA06", Offset = "0xBA06", VA = "0xBA06")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06006FA6 RID: 28582 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FA7 RID: 28583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016C9")]
		public IApp App
		{
			[Token(Token = "0x6006FA6")]
			[Address(RVA = "0xBA07", Offset = "0xBA07", VA = "0xBA07")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FA7")]
			[Address(RVA = "0xBA08", Offset = "0xBA08", VA = "0xBA08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06006FA8 RID: 28584 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FA9 RID: 28585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016CA")]
		private IConnection Connection
		{
			[Token(Token = "0x6006FA8")]
			[Address(RVA = "0xBA09", Offset = "0xBA09", VA = "0xBA09")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FA9")]
			[Address(RVA = "0xBA0A", Offset = "0xBA0A", VA = "0xBA0A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06006FAA RID: 28586 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FAB RID: 28587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016CB")]
		public IRecoveryConnection RecoveryConnection
		{
			[Token(Token = "0x6006FAA")]
			[Address(RVA = "0xBA0B", Offset = "0xBA0B", VA = "0xBA0B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FAB")]
			[Address(RVA = "0xBA0C", Offset = "0xBA0C", VA = "0xBA0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06006FAC RID: 28588 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FAD RID: 28589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016CC")]
		public ISystemDisconnectResolver DisconnectResolver
		{
			[Token(Token = "0x6006FAC")]
			[Address(RVA = "0xBA0D", Offset = "0xBA0D", VA = "0xBA0D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FAD")]
			[Address(RVA = "0xBA0E", Offset = "0xBA0E", VA = "0xBA0E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06006FAE RID: 28590 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006FAF RID: 28591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016CD")]
		public LowResponseAbilityMonitor LatencyMonitor
		{
			[Token(Token = "0x6006FAE")]
			[Address(RVA = "0xBA0F", Offset = "0xBA0F", VA = "0xBA0F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006FAF")]
			[Address(RVA = "0xBA10", Offset = "0xBA10", VA = "0xBA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006FB0 RID: 28592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB0")]
		[Address(RVA = "0xBA11", Offset = "0xBA11", VA = "0xBA11")]
		public ConnectionManager(IApp app)
		{
		}

		// Token: 0x06006FB1 RID: 28593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB1")]
		[Address(RVA = "0xBA12", Offset = "0xBA12", VA = "0xBA12", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006FB2 RID: 28594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB2")]
		[Address(RVA = "0xBA13", Offset = "0xBA13", VA = "0xBA13", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006FB3 RID: 28595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB3")]
		[Address(RVA = "0xBA14", Offset = "0xBA14", VA = "0xBA14", Slot = "13")]
		public void ReConnect(Uri uri, Action callback)
		{
		}

		// Token: 0x06006FB4 RID: 28596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB4")]
		[Address(RVA = "0xBA15", Offset = "0xBA15", VA = "0xBA15", Slot = "12")]
		public void ReConnect(Action callback)
		{
		}

		// Token: 0x06006FB5 RID: 28597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB5")]
		[Address(RVA = "0xBA16", Offset = "0xBA16", VA = "0xBA16", Slot = "11")]
		public void RunConnect()
		{
		}

		// Token: 0x06006FB6 RID: 28598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB6")]
		[Address(RVA = "0xBA17", Offset = "0xBA17", VA = "0xBA17")]
		private void HandleLatencyMonitorTestRunEvent(double avgLatency)
		{
		}

		// Token: 0x06006FB7 RID: 28599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB7")]
		[Address(RVA = "0xBA18", Offset = "0xBA18", VA = "0xBA18")]
		private void HandleConnectionStateEvent(ConnectionState state)
		{
		}

		// Token: 0x06006FB8 RID: 28600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB8")]
		[Address(RVA = "0xBA19", Offset = "0xBA19", VA = "0xBA19")]
		private void HandleConnectionClosedEvent(DisconnectCode code)
		{
		}

		// Token: 0x06006FB9 RID: 28601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FB9")]
		[Address(RVA = "0xBA1A", Offset = "0xBA1A", VA = "0xBA1A")]
		private void HandleServerReadyToStopEvent()
		{
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006FBA")]
		[Address(RVA = "0xBA1B", Offset = "0xBA1B", VA = "0xBA1B")]
		private IEnumerator ConnectCoroutine(float delay)
		{
			return null;
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FBB")]
		[Address(RVA = "0xBA1C", Offset = "0xBA1C", VA = "0xBA1C")]
		private void InstanceOnAppQuitEvent()
		{
		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006FBC")]
		[Address(RVA = "0xBA1D", Offset = "0xBA1D", VA = "0xBA1D")]
		private IEnumerator Internal_ReConnect(Action completeCallback)
		{
			return null;
		}

		// Token: 0x04003A4E RID: 14926
		[Token(Token = "0x4003A4E")]
		public const int FIRST_TIME_CONNECTION_COUNT = 1;

		// Token: 0x04003A50 RID: 14928
		[Token(Token = "0x4003A50")]
		[FieldOffset(Offset = "0x14")]
		private ConnectionInformer _informer;

		// Token: 0x04003A51 RID: 14929
		[Token(Token = "0x4003A51")]
		[FieldOffset(Offset = "0x18")]
		private ConnectionStateLogger _logger;

		// Token: 0x04003A52 RID: 14930
		[Token(Token = "0x4003A52")]
		[FieldOffset(Offset = "0x1C")]
		private Ping _ping;

		// Token: 0x04003A58 RID: 14936
		[Token(Token = "0x4003A58")]
		[FieldOffset(Offset = "0x34")]
		public ServerConnectionDelay ConnectionDelay;
	}
}
