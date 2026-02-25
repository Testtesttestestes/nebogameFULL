using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Analytics.Service;
using Core.Events;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012B9 RID: 4793
	[Token(Token = "0x20012B9")]
	public abstract class AbstractAnalyticsListener : IDisposable
	{
		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x060071BF RID: 29119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700171C")]
		protected IAnalyticsApi AnalyticsServiceProxy
		{
			[Token(Token = "0x60071BF")]
			[Address(RVA = "0xBBCD", Offset = "0xBBCD", VA = "0xBBCD")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x060071C0 RID: 29120
		[Token(Token = "0x1700171D")]
		protected abstract string Theme { [Token(Token = "0x60071C0")] get; }

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x060071C1 RID: 29121 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060071C2 RID: 29122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700171E")]
		public virtual EventBus EventBus
		{
			[Token(Token = "0x60071C1")]
			[Address(RVA = "0xBBCE", Offset = "0xBBCE", VA = "0xBBCE", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60071C2")]
			[Address(RVA = "0xBBCF", Offset = "0xBBCF", VA = "0xBBCF", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x060071C3 RID: 29123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071C3")]
		[Address(RVA = "0xBBD0", Offset = "0xBBD0", VA = "0xBBD0", Slot = "8")]
		public virtual void AddService(IAnalyticsService service)
		{
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071C4")]
		[Address(RVA = "0xBBD1", Offset = "0xBBD1", VA = "0xBBD1", Slot = "9")]
		public virtual void RemoveService(IAnalyticsService service)
		{
		}

		// Token: 0x060071C5 RID: 29125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60071C5")]
		[Address(RVA = "0xBBD2", Offset = "0xBBD2", VA = "0xBBD2")]
		protected Dictionary<string, object> GetEmptyProperties()
		{
			return null;
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60071C6")]
		[Address(RVA = "0xBBD3", Offset = "0xBBD3", VA = "0xBBD3")]
		protected string GetDateString()
		{
			return null;
		}

		// Token: 0x060071C7 RID: 29127 RVA: 0x00014B38 File Offset: 0x00012D38
		[Token(Token = "0x60071C7")]
		[Address(RVA = "0xBBD4", Offset = "0xBBD4", VA = "0xBBD4")]
		protected long GetTs()
		{
			return 0L;
		}

		// Token: 0x060071C8 RID: 29128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071C8")]
		[Address(RVA = "0x1EBE", Offset = "0x1EBE", VA = "0x1EBE")]
		protected void AppendResourceSetToProperties(Dictionary<string, object> properties, ResourceSet price, string prefix)
		{
		}

		// Token: 0x060071C9 RID: 29129 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60071C9")]
		[Address(RVA = "0xBBD5", Offset = "0xBBD5", VA = "0xBBD5")]
		protected string GetResourceAnalyticsName(Resources resource)
		{
			return null;
		}

		// Token: 0x060071CA RID: 29130
		[Token(Token = "0x60071CA")]
		public abstract void Init();

		// Token: 0x060071CB RID: 29131
		[Token(Token = "0x60071CB")]
		protected abstract void Deinit();

		// Token: 0x060071CC RID: 29132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071CC")]
		[Address(RVA = "0x2273", Offset = "0x2273", VA = "0x2273", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060071CD RID: 29133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071CD")]
		[Address(RVA = "0xBBD6", Offset = "0xBBD6", VA = "0xBBD6")]
		protected AbstractAnalyticsListener()
		{
		}

		// Token: 0x04003BA1 RID: 15265
		[Token(Token = "0x4003BA1")]
		[FieldOffset(Offset = "0x8")]
		private AbstractAnalyticsListener.MultipleAnalyticsServiceProxy _analyticsProxy;

		// Token: 0x04003BA2 RID: 15266
		[Token(Token = "0x4003BA2")]
		[FieldOffset(Offset = "0xC")]
		private EventBus _eventBus;

		// Token: 0x020012BA RID: 4794
		[Token(Token = "0x20012BA")]
		private class MultipleAnalyticsServiceProxy : IAnalyticsApi
		{
			// Token: 0x1700171F RID: 5919
			// (get) Token: 0x060071CE RID: 29134 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700171F")]
			public HashSet<IAnalyticsService> Services
			{
				[Token(Token = "0x60071CE")]
				[Address(RVA = "0xBBD7", Offset = "0xBBD7", VA = "0xBBD7")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060071CF RID: 29135 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071CF")]
			[Address(RVA = "0xBBD8", Offset = "0xBBD8", VA = "0xBBD8", Slot = "4")]
			public void SetUserPropertyOnce(string property, object value)
			{
			}

			// Token: 0x060071D0 RID: 29136 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071D0")]
			[Address(RVA = "0xBBD9", Offset = "0xBBD9", VA = "0xBBD9", Slot = "5")]
			public void SetUserProperty(string property, object value)
			{
			}

			// Token: 0x060071D1 RID: 29137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071D1")]
			[Address(RVA = "0xBBDA", Offset = "0xBBDA", VA = "0xBBDA", Slot = "6")]
			public void AddUserProperty(string property, object value)
			{
			}

			// Token: 0x060071D2 RID: 29138 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071D2")]
			[Address(RVA = "0xBBDB", Offset = "0xBBDB", VA = "0xBBDB", Slot = "7")]
			public void LogEvent(string eventTheme, string eventName, IDictionary<string, object> properties)
			{
			}

			// Token: 0x060071D3 RID: 29139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071D3")]
			[Address(RVA = "0xBBDC", Offset = "0xBBDC", VA = "0xBBDC", Slot = "8")]
			public void LogRevenue(string productId, int quantity, double price, IDictionary<string, object> eventProperties)
			{
			}

			// Token: 0x060071D4 RID: 29140 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071D4")]
			[Address(RVA = "0xBBDD", Offset = "0xBBDD", VA = "0xBBDD")]
			public MultipleAnalyticsServiceProxy()
			{
			}
		}
	}
}
