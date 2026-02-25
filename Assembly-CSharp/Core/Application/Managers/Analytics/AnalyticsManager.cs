using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Analytics;
using Core.Analytics.Listeners;
using Core.Analytics.Service.Android;
using Il2CppDummyDll;

namespace Core.Application.Managers.Analytics
{
	// Token: 0x02001276 RID: 4726
	[Token(Token = "0x2001276")]
	public class AnalyticsManager : IAppManager, IBaseManager, IAnalyticsListenerProvider
	{
		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06007020 RID: 28704 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016E1")]
		public string Name
		{
			[Token(Token = "0x6007020")]
			[Address(RVA = "0xBA67", Offset = "0xBA67", VA = "0xBA67", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002F9 RID: 761
		// (add) Token: 0x06007021 RID: 28705 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007022 RID: 28706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F9")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6007021")]
			[Address(RVA = "0xBA68", Offset = "0xBA68", VA = "0xBA68", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007022")]
			[Address(RVA = "0xBA69", Offset = "0xBA69", VA = "0xBA69", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002FA RID: 762
		// (add) Token: 0x06007023 RID: 28707 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007024 RID: 28708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002FA")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6007023")]
			[Address(RVA = "0xBA6A", Offset = "0xBA6A", VA = "0xBA6A", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007024")]
			[Address(RVA = "0xBA6B", Offset = "0xBA6B", VA = "0xBA6B", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06007025 RID: 28709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007025")]
		public T GetAnalyticsListener<T>() where T : AbstractAnalyticsListener, new()
		{
			return null;
		}

		// Token: 0x06007026 RID: 28710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007026")]
		[Address(RVA = "0xBA6C", Offset = "0xBA6C", VA = "0xBA6C", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06007027 RID: 28711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007027")]
		[Address(RVA = "0xBA6D", Offset = "0xBA6D", VA = "0xBA6D")]
		private void CreateAnalyticsServices()
		{
		}

		// Token: 0x06007028 RID: 28712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007028")]
		[Address(RVA = "0xBA6E", Offset = "0xBA6E", VA = "0xBA6E", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06007029 RID: 28713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007029")]
		[Address(RVA = "0xBA6F", Offset = "0xBA6F", VA = "0xBA6F")]
		public AnalyticsManager()
		{
		}

		// Token: 0x04003A85 RID: 14981
		[Token(Token = "0x4003A85")]
		[FieldOffset(Offset = "0x10")]
		private AbstractAnalyticsServiceProvider _analyticsServiceProvider;

		// Token: 0x04003A86 RID: 14982
		[Token(Token = "0x4003A86")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<Type, AbstractAnalyticsListener> _analyticsListeners;

		// Token: 0x04003A87 RID: 14983
		[Token(Token = "0x4003A87")]
		[FieldOffset(Offset = "0x18")]
		private DeviceIDProvider _deviceIDProvider;
	}
}
