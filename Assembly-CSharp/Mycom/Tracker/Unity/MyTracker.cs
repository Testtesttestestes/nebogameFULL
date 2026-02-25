using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Mycom.Tracker.Unity.Ads;
using Mycom.Tracker.Unity.Internal.Interfaces;

namespace Mycom.Tracker.Unity
{
	// Token: 0x0200133E RID: 4926
	[Token(Token = "0x200133E")]
	public static class MyTracker
	{
		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06007494 RID: 29844 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700177B")]
		public static string InstanceId
		{
			[Token(Token = "0x6007494")]
			[Address(RVA = "0xBE60", Offset = "0xBE60", VA = "0xBE60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06007495 RID: 29845 RVA: 0x00014FD0 File Offset: 0x000131D0
		// (set) Token: 0x06007496 RID: 29846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700177C")]
		public static bool IsDebugMode
		{
			[Token(Token = "0x6007495")]
			[Address(RVA = "0xBE61", Offset = "0xBE61", VA = "0xBE61")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007496")]
			[Address(RVA = "0xBE62", Offset = "0xBE62", VA = "0xBE62")]
			set
			{
			}
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06007497 RID: 29847 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700177D")]
		public static MyTrackerParams MyTrackerParams
		{
			[Token(Token = "0x6007497")]
			[Address(RVA = "0xBE63", Offset = "0xBE63", VA = "0xBE63")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06007498 RID: 29848 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700177E")]
		public static MyTrackerConfig MyTrackerConfig
		{
			[Token(Token = "0x6007498")]
			[Address(RVA = "0xBE64", Offset = "0xBE64", VA = "0xBE64")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007499 RID: 29849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007499")]
		[Address(RVA = "0xBE65", Offset = "0xBE65", VA = "0xBE65")]
		public static void Init(string id)
		{
		}

		// Token: 0x0600749A RID: 29850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600749A")]
		[Address(RVA = "0xBE66", Offset = "0xBE66", VA = "0xBE66")]
		public static void SetAttributionListener(Action<MyTrackerAttribution> listener)
		{
		}

		// Token: 0x0600749B RID: 29851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600749B")]
		[Address(RVA = "0xBE67", Offset = "0xBE67", VA = "0xBE67")]
		public static void TrackEvent(string name, [Optional] IDictionary<string, string> eventParams)
		{
		}

		// Token: 0x0600749C RID: 29852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600749C")]
		[Address(RVA = "0xBE68", Offset = "0xBE68", VA = "0xBE68")]
		public static void TrackInviteEvent([Optional] IDictionary<string, string> eventParams)
		{
		}

		// Token: 0x0600749D RID: 29853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600749D")]
		[Address(RVA = "0xBE69", Offset = "0xBE69", VA = "0xBE69")]
		public static void TrackLevelEvent([Optional] int? level, [Optional] IDictionary<string, string> eventParams)
		{
		}

		// Token: 0x0600749E RID: 29854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600749E")]
		[Address(RVA = "0xBE6A", Offset = "0xBE6A", VA = "0xBE6A")]
		public static void TrackLoginEvent(string userId, string vkConnectId, [Optional] IDictionary<string, string> eventParams)
		{
		}

		// Token: 0x0600749F RID: 29855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600749F")]
		[Address(RVA = "0xBE6B", Offset = "0xBE6B", VA = "0xBE6B")]
		public static void TrackRegistrationEvent(string userId, string vkConnectId, [Optional] IDictionary<string, string> eventParams)
		{
		}

		// Token: 0x060074A0 RID: 29856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074A0")]
		[Address(RVA = "0xBE6C", Offset = "0xBE6C", VA = "0xBE6C")]
		public static void TrackAdEvent(AdEvent adEvent)
		{
		}

		// Token: 0x060074A1 RID: 29857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074A1")]
		[Address(RVA = "0xBE6D", Offset = "0xBE6D", VA = "0xBE6D")]
		public static void Flush()
		{
		}

		// Token: 0x04003D35 RID: 15669
		[Token(Token = "0x4003D35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ITracker Tracker;

		// Token: 0x04003D36 RID: 15670
		[Token(Token = "0x4003D36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int State;
	}
}
