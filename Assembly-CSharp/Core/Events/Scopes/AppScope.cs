using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Core.Net;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02000FC1 RID: 4033
	[Token(Token = "0x2000FC1")]
	public class AppScope : AbstractEventBusScope
	{
		// Token: 0x06006085 RID: 24709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006085")]
		[Address(RVA = "0xACB1", Offset = "0xACB1", VA = "0xACB1", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006086")]
		[Address(RVA = "0xACB2", Offset = "0xACB2", VA = "0xACB2")]
		public AppScope()
		{
		}

		// Token: 0x04003373 RID: 13171
		[Token(Token = "0x4003373")]
		[FieldOffset(Offset = "0x8")]
		public Action<BaseEventBusEventArgs> AppInitEvent;

		// Token: 0x04003374 RID: 13172
		[Token(Token = "0x4003374")]
		[FieldOffset(Offset = "0xC")]
		public Action<BaseEventBusEventArgs> AppInitCompleteEvent;

		// Token: 0x04003375 RID: 13173
		[Token(Token = "0x4003375")]
		[FieldOffset(Offset = "0x10")]
		public Action<BaseEventBusEventArgs> ServerIdChangedEvent;

		// Token: 0x04003376 RID: 13174
		[Token(Token = "0x4003376")]
		[FieldOffset(Offset = "0x14")]
		public Action<BaseEventBusEventArgs> GameInitCompleteEvent;

		// Token: 0x04003377 RID: 13175
		[Token(Token = "0x4003377")]
		[FieldOffset(Offset = "0x18")]
		public Action<AppScope.UnhandledExceptionEventArgs> UnhandledExceptionEvent;

		// Token: 0x04003378 RID: 13176
		[Token(Token = "0x4003378")]
		[FieldOffset(Offset = "0x1C")]
		public Action<AppScope.AverageFpsCalculatedEventArgs> AverageFpsCalculatedEvent;

		// Token: 0x04003379 RID: 13177
		[Token(Token = "0x4003379")]
		[FieldOffset(Offset = "0x20")]
		public Action<AppScope.AnswerFromServerReceivedEventArgs> AnswerFromServerReceivedEvent;

		// Token: 0x0400337A RID: 13178
		[Token(Token = "0x400337A")]
		[FieldOffset(Offset = "0x24")]
		public Action<AppScope.LoadingEventArgs> AppLoadingEvent;

		// Token: 0x0400337B RID: 13179
		[Token(Token = "0x400337B")]
		[FieldOffset(Offset = "0x28")]
		public Action<AppScope.LoadingEventArgs> GameLoadingEvent;

		// Token: 0x0400337C RID: 13180
		[Token(Token = "0x400337C")]
		[FieldOffset(Offset = "0x2C")]
		public Action<AppScope.LatencyMonitorArgs> LatencyMonitorEvent;

		// Token: 0x02000FC2 RID: 4034
		[Token(Token = "0x2000FC2")]
		public class UnhandledExceptionEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x170012FA RID: 4858
			// (get) Token: 0x06006087 RID: 24711 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170012FA")]
			public string Condition
			{
				[Token(Token = "0x6006087")]
				[Address(RVA = "0xACB3", Offset = "0xACB3", VA = "0xACB3")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170012FB RID: 4859
			// (get) Token: 0x06006088 RID: 24712 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170012FB")]
			public string Stacktrace
			{
				[Token(Token = "0x6006088")]
				[Address(RVA = "0xACB4", Offset = "0xACB4", VA = "0xACB4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06006089 RID: 24713 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006089")]
			[Address(RVA = "0xACB5", Offset = "0xACB5", VA = "0xACB5")]
			public UnhandledExceptionEventArgs(App app, IGame game, string condition, string stacktrace)
			{
			}
		}

		// Token: 0x02000FC3 RID: 4035
		[Token(Token = "0x2000FC3")]
		public class AverageFpsCalculatedEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x170012FC RID: 4860
			// (get) Token: 0x0600608A RID: 24714 RVA: 0x00011940 File Offset: 0x0000FB40
			[Token(Token = "0x170012FC")]
			public float FPS
			{
				[Token(Token = "0x600608A")]
				[Address(RVA = "0xACB6", Offset = "0xACB6", VA = "0xACB6")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}

			// Token: 0x0600608B RID: 24715 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600608B")]
			[Address(RVA = "0xACB7", Offset = "0xACB7", VA = "0xACB7")]
			public AverageFpsCalculatedEventArgs(App app, IGame game, float fps)
			{
			}
		}

		// Token: 0x02000FC4 RID: 4036
		[Token(Token = "0x2000FC4")]
		public class AnswerFromServerReceivedEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x170012FD RID: 4861
			// (get) Token: 0x0600608C RID: 24716 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170012FD")]
			public SrvCommand Command
			{
				[Token(Token = "0x600608C")]
				[Address(RVA = "0xACB8", Offset = "0xACB8", VA = "0xACB8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600608D RID: 24717 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600608D")]
			[Address(RVA = "0xACB9", Offset = "0xACB9", VA = "0xACB9")]
			public AnswerFromServerReceivedEventArgs(App app, IGame game, SrvCommand command)
			{
			}
		}

		// Token: 0x02000FC5 RID: 4037
		[Token(Token = "0x2000FC5")]
		public class LoadingEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x170012FE RID: 4862
			// (get) Token: 0x0600608E RID: 24718 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170012FE")]
			public string Name
			{
				[Token(Token = "0x600608E")]
				[Address(RVA = "0xACBA", Offset = "0xACBA", VA = "0xACBA")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170012FF RID: 4863
			// (get) Token: 0x0600608F RID: 24719 RVA: 0x00011958 File Offset: 0x0000FB58
			[Token(Token = "0x170012FF")]
			public int Index
			{
				[Token(Token = "0x600608F")]
				[Address(RVA = "0xACBB", Offset = "0xACBB", VA = "0xACBB")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001300 RID: 4864
			// (get) Token: 0x06006090 RID: 24720 RVA: 0x00011970 File Offset: 0x0000FB70
			[Token(Token = "0x17001300")]
			public int Total
			{
				[Token(Token = "0x6006090")]
				[Address(RVA = "0xACBC", Offset = "0xACBC", VA = "0xACBC")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x06006091 RID: 24721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006091")]
			[Address(RVA = "0xACBD", Offset = "0xACBD", VA = "0xACBD")]
			public LoadingEventArgs(App app, IGame game, string name, int index, int total)
			{
			}
		}

		// Token: 0x02000FC6 RID: 4038
		[Token(Token = "0x2000FC6")]
		public class LatencyMonitorArgs
		{
			// Token: 0x06006092 RID: 24722 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006092")]
			[Address(RVA = "0xACBE", Offset = "0xACBE", VA = "0xACBE")]
			public LatencyMonitorArgs(double startTestAvgLatency)
			{
			}

			// Token: 0x04003384 RID: 13188
			[Token(Token = "0x4003384")]
			[FieldOffset(Offset = "0x8")]
			public readonly double? StartTestAvgLatency;
		}
	}
}
