using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Core.Net.Monitor.Responseability.Analysis;
using Core.Net.Monitor.Responseability.Testing.Common;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Net.Monitor.Responseability
{
	// Token: 0x02000E98 RID: 3736
	[Token(Token = "0x2000E98")]
	public class LowResponseAbilityMonitor : ILowResponseAbilityMonitor, IDisposable
	{
		// Token: 0x14000225 RID: 549
		// (add) Token: 0x06005AD0 RID: 23248 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005AD1 RID: 23249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000225")]
		public event Action<ResponseAbilityStatus> ResponseAbilityChangedEvent
		{
			[Token(Token = "0x6005AD0")]
			[Address(RVA = "0xA7B4", Offset = "0xA7B4", VA = "0xA7B4", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005AD1")]
			[Address(RVA = "0xA7B5", Offset = "0xA7B5", VA = "0xA7B5", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000226 RID: 550
		// (add) Token: 0x06005AD2 RID: 23250 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005AD3 RID: 23251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000226")]
		public event Action<bool> ResponseTimeExceededEvent
		{
			[Token(Token = "0x6005AD2")]
			[Address(RVA = "0xA7B6", Offset = "0xA7B6", VA = "0xA7B6", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005AD3")]
			[Address(RVA = "0xA7B7", Offset = "0xA7B7", VA = "0xA7B7", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000227 RID: 551
		// (add) Token: 0x06005AD4 RID: 23252 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005AD5 RID: 23253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000227")]
		public event Action<double> TestRunEvent
		{
			[Token(Token = "0x6005AD4")]
			[Address(RVA = "0xA7B8", Offset = "0xA7B8", VA = "0xA7B8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005AD5")]
			[Address(RVA = "0xA7B9", Offset = "0xA7B9", VA = "0xA7B9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06005AD6 RID: 23254 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005AD7 RID: 23255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001283")]
		public Configuration Config
		{
			[Token(Token = "0x6005AD6")]
			[Address(RVA = "0xA7BA", Offset = "0xA7BA", VA = "0xA7BA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AD7")]
			[Address(RVA = "0xA7BB", Offset = "0xA7BB", VA = "0xA7BB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06005AD8 RID: 23256 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005AD9 RID: 23257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001284")]
		public IAnalysis Analysis
		{
			[Token(Token = "0x6005AD8")]
			[Address(RVA = "0xA7BC", Offset = "0xA7BC", VA = "0xA7BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AD9")]
			[Address(RVA = "0xA7BD", Offset = "0xA7BD", VA = "0xA7BD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005ADA RID: 23258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ADA")]
		[Address(RVA = "0xA7BE", Offset = "0xA7BE", VA = "0xA7BE", Slot = "10")]
		public void Dispose()
		{
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ADB")]
		[Address(RVA = "0xA7BF", Offset = "0xA7BF", VA = "0xA7BF")]
		public LowResponseAbilityMonitor([NotNull] SynchronizationContext synchronizationContext, [NotNull] object syncMonitor, [NotNull] INetTestLauncher netTestLauncher, [NotNull] IAnalysis analysis, [NotNull] Configuration configuration, bool debug = false)
		{
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ADC")]
		[Address(RVA = "0xA7C0", Offset = "0xA7C0", VA = "0xA7C0", Slot = "9")]
		public void Monitor(ISrvAnswer value)
		{
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ADD")]
		[Address(RVA = "0xA7C1", Offset = "0xA7C1", VA = "0xA7C1", Slot = "8")]
		public void Monitor(IEnumerable<ISrvCommand> value)
		{
		}

		// Token: 0x06005ADE RID: 23262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ADE")]
		[Address(RVA = "0xA7C2", Offset = "0xA7C2", VA = "0xA7C2")]
		private void SetIsResponseTimeExceeded(bool value)
		{
		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005ADF")]
		[Address(RVA = "0xA7C3", Offset = "0xA7C3", VA = "0xA7C3")]
		private void SetStatus(ResponseAbilityStatus value)
		{
		}

		// Token: 0x06005AE0 RID: 23264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE0")]
		[Address(RVA = "0xA7C4", Offset = "0xA7C4", VA = "0xA7C4")]
		private void StatusChangedPostContextCallback(object value)
		{
		}

		// Token: 0x06005AE1 RID: 23265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE1")]
		[Address(RVA = "0x3632", Offset = "0x3632", VA = "0x3632")]
		private void RequestTest(double avgLatency)
		{
		}

		// Token: 0x06005AE2 RID: 23266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE2")]
		[Address(RVA = "0xA7C5", Offset = "0xA7C5", VA = "0xA7C5")]
		private void SetTest(INetTest test)
		{
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE3")]
		[Address(RVA = "0xA7C6", Offset = "0xA7C6", VA = "0xA7C6")]
		private void ResetTest()
		{
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE4")]
		[Address(RVA = "0xA7C7", Offset = "0xA7C7", VA = "0xA7C7")]
		private void SetTestRequest(bool value)
		{
		}

		// Token: 0x040031A7 RID: 12711
		[Token(Token = "0x40031A7")]
		[FieldOffset(Offset = "0x1C")]
		private ResponseAbilityStatus _status;

		// Token: 0x040031A8 RID: 12712
		[Token(Token = "0x40031A8")]
		[FieldOffset(Offset = "0x20")]
		private SynchronizationContext _synchronizationContext;

		// Token: 0x040031A9 RID: 12713
		[Token(Token = "0x40031A9")]
		[FieldOffset(Offset = "0x24")]
		private INetTestLauncher _netTestLauncher;

		// Token: 0x040031AA RID: 12714
		[Token(Token = "0x40031AA")]
		[FieldOffset(Offset = "0x28")]
		private INetTest _currentTest;

		// Token: 0x040031AB RID: 12715
		[Token(Token = "0x40031AB")]
		[FieldOffset(Offset = "0x2C")]
		private bool _isResponseTimeExceeded;

		// Token: 0x040031AC RID: 12716
		[Token(Token = "0x40031AC")]
		[FieldOffset(Offset = "0x2D")]
		private bool _testRequested;

		// Token: 0x040031AD RID: 12717
		[Token(Token = "0x40031AD")]
		[FieldOffset(Offset = "0x30")]
		private readonly object _syncMonitor;

		// Token: 0x040031AE RID: 12718
		[Token(Token = "0x40031AE")]
		[FieldOffset(Offset = "0x34")]
		private readonly bool _debug;
	}
}
