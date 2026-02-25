using System;
using System.Collections.Generic;
using Core.Analytics.Service.Android;
using Core.Events;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012BE RID: 4798
	[Token(Token = "0x20012BE")]
	public class AppAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x060071EB RID: 29163 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001723")]
		protected override string Theme
		{
			[Token(Token = "0x60071EB")]
			[Address(RVA = "0xBBF4", Offset = "0xBBF4", VA = "0xBBF4", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071EC RID: 29164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071EC")]
		[Address(RVA = "0xBBF5", Offset = "0xBBF5", VA = "0xBBF5", Slot = "10")]
		public override void Init()
		{
		}

		// Token: 0x060071ED RID: 29165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071ED")]
		[Address(RVA = "0xBBF6", Offset = "0xBBF6", VA = "0xBBF6", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x060071EE RID: 29166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071EE")]
		[Address(RVA = "0xBBF7", Offset = "0xBBF7", VA = "0xBBF7")]
		private void LatencyMonitorEvent(AppScope.LatencyMonitorArgs value)
		{
		}

		// Token: 0x060071EF RID: 29167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071EF")]
		[Address(RVA = "0xBBF8", Offset = "0xBBF8", VA = "0xBBF8")]
		private void GameLoadingEvent(AppScope.LoadingEventArgs e)
		{
		}

		// Token: 0x060071F0 RID: 29168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F0")]
		[Address(RVA = "0xBBF9", Offset = "0xBBF9", VA = "0xBBF9")]
		private void AppLoadingEvent(AppScope.LoadingEventArgs e)
		{
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F1")]
		[Address(RVA = "0xBBFA", Offset = "0xBBFA", VA = "0xBBFA")]
		private void AnswerFromServerReceivedEvent(AppScope.AnswerFromServerReceivedEventArgs e)
		{
		}

		// Token: 0x060071F2 RID: 29170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F2")]
		[Address(RVA = "0xBBFB", Offset = "0xBBFB", VA = "0xBBFB")]
		private void AverageFpsCalculatedEvent(AppScope.AverageFpsCalculatedEventArgs e)
		{
		}

		// Token: 0x060071F3 RID: 29171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F3")]
		[Address(RVA = "0xBBFC", Offset = "0xBBFC", VA = "0xBBFC")]
		private void UnhandledExceptionEvent(AppScope.UnhandledExceptionEventArgs e)
		{
		}

		// Token: 0x060071F4 RID: 29172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F4")]
		[Address(RVA = "0xBBFD", Offset = "0xBBFD", VA = "0xBBFD")]
		private void InitAppEvent(BaseEventBusEventArgs obj)
		{
		}

		// Token: 0x060071F5 RID: 29173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F5")]
		[Address(RVA = "0xBBFE", Offset = "0xBBFE", VA = "0xBBFE")]
		private void SetSystemUserProperties()
		{
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F6")]
		[Address(RVA = "0xBBFF", Offset = "0xBBFF", VA = "0xBBFF")]
		private void GameInitCompleteEvent(BaseEventBusEventArgs e)
		{
		}

		// Token: 0x060071F7 RID: 29175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F7")]
		[Address(RVA = "0xBC00", Offset = "0xBC00", VA = "0xBC00")]
		private void AppInitCompleteEvent(BaseEventBusEventArgs e)
		{
		}

		// Token: 0x060071F8 RID: 29176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F8")]
		[Address(RVA = "0xBC01", Offset = "0xBC01", VA = "0xBC01")]
		private void ServerIdChangedEvent(BaseEventBusEventArgs e)
		{
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F9")]
		[Address(RVA = "0xBC02", Offset = "0xBC02", VA = "0xBC02")]
		public AppAnalyticsListener()
		{
		}

		// Token: 0x04003BAE RID: 15278
		[Token(Token = "0x4003BAE")]
		public const string THEME = "app";

		// Token: 0x04003BAF RID: 15279
		[Token(Token = "0x4003BAF")]
		[FieldOffset(Offset = "0x10")]
		private DeviceIDProvider _deviceIDProvider;

		// Token: 0x04003BB0 RID: 15280
		[Token(Token = "0x4003BB0")]
		private const int MaxUnhandledExceptionsNum = 3;

		// Token: 0x04003BB1 RID: 15281
		[Token(Token = "0x4003BB1")]
		[FieldOffset(Offset = "0x14")]
		private int _unhandledExceptionCounter;

		// Token: 0x04003BB2 RID: 15282
		[Token(Token = "0x4003BB2")]
		private const string INIT = "init";

		// Token: 0x04003BB3 RID: 15283
		[Token(Token = "0x4003BB3")]
		public const string APP_LOADING = "app_loading";

		// Token: 0x04003BB4 RID: 15284
		[Token(Token = "0x4003BB4")]
		public const string GAME_LOADING = "game_loading";

		// Token: 0x04003BB5 RID: 15285
		[Token(Token = "0x4003BB5")]
		public const string APP_LOADING_COMPLETE = "app_loading_complete";

		// Token: 0x04003BB6 RID: 15286
		[Token(Token = "0x4003BB6")]
		public const string GAME_LOADING_COMPLETE = "game_loading_complete";

		// Token: 0x04003BB7 RID: 15287
		[Token(Token = "0x4003BB7")]
		private const string UNHANDLED_EXCEPTION = "unhandled_exception";

		// Token: 0x04003BB8 RID: 15288
		[Token(Token = "0x4003BB8")]
		private const string SERVER_ID = "server";

		// Token: 0x04003BB9 RID: 15289
		[Token(Token = "0x4003BB9")]
		private const string LATENCY_MONITOR = "latency_monitor";

		// Token: 0x04003BBA RID: 15290
		[Token(Token = "0x4003BBA")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Tuple<short, short>, string> _loggingLatencies;
	}
}
