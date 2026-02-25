using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Mycom.Tracker.Unity.Ads;
using Mycom.Tracker.Unity.Internal.Interfaces;

namespace Mycom.Tracker.Unity.Internal.Implementations.Fake
{
	// Token: 0x02001349 RID: 4937
	[Token(Token = "0x2001349")]
	internal sealed class Tracker : ITracker, IDisposable
	{
		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x0600751C RID: 29980 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700179F")]
		private MyTrackerParams MyTrackerParams
		{
			[Token(Token = "0x600751C")]
			[Address(RVA = "0xBEB0", Offset = "0xBEB0", VA = "0xBEB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x0600751D RID: 29981 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017A0")]
		private MyTrackerConfig MyTrackerConfig
		{
			[Token(Token = "0x600751D")]
			[Address(RVA = "0xBEB1", Offset = "0xBEB1", VA = "0xBEB1", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600751E RID: 29982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600751E")]
		[Address(RVA = "0xBEB2", Offset = "0xBEB2", VA = "0xBEB2", Slot = "18")]
		private void Dispose()
		{
		}

		// Token: 0x0600751F RID: 29983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600751F")]
		[Address(RVA = "0xBEB3", Offset = "0xBEB3", VA = "0xBEB3", Slot = "17")]
		private void Flush()
		{
		}

		// Token: 0x06007520 RID: 29984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007520")]
		[Address(RVA = "0xBEB4", Offset = "0xBEB4", VA = "0xBEB4", Slot = "7")]
		private void Init(string id)
		{
		}

		// Token: 0x06007521 RID: 29985 RVA: 0x000150C0 File Offset: 0x000132C0
		[Token(Token = "0x6007521")]
		[Address(RVA = "0xBEB5", Offset = "0xBEB5", VA = "0xBEB5", Slot = "8")]
		private bool IsDebugMode()
		{
			return default(bool);
		}

		// Token: 0x06007522 RID: 29986 RVA: 0x000150D8 File Offset: 0x000132D8
		[Token(Token = "0x6007522")]
		[Address(RVA = "0xBEB6", Offset = "0xBEB6", VA = "0xBEB6")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		// Token: 0x06007523 RID: 29987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007523")]
		[Address(RVA = "0xBEB7", Offset = "0xBEB7", VA = "0xBEB7", Slot = "9")]
		private void SetAttributionListener(Action<MyTrackerAttribution> listener)
		{
		}

		// Token: 0x06007524 RID: 29988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007524")]
		[Address(RVA = "0xBEB8", Offset = "0xBEB8", VA = "0xBEB8", Slot = "10")]
		private void SetDebugMode(bool value)
		{
		}

		// Token: 0x06007525 RID: 29989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007525")]
		[Address(RVA = "0xBEB9", Offset = "0xBEB9", VA = "0xBEB9")]
		public void SetEnabled(bool value)
		{
		}

		// Token: 0x06007526 RID: 29990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007526")]
		[Address(RVA = "0xBEBA", Offset = "0xBEBA", VA = "0xBEBA", Slot = "11")]
		private void TrackEvent(string name, IDictionary<string, string> eventParams)
		{
		}

		// Token: 0x06007527 RID: 29991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007527")]
		[Address(RVA = "0xBEBB", Offset = "0xBEBB", VA = "0xBEBB", Slot = "12")]
		private void TrackInviteEvent(IDictionary<string, string> eventParams)
		{
		}

		// Token: 0x06007528 RID: 29992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007528")]
		[Address(RVA = "0xBEBC", Offset = "0xBEBC", VA = "0xBEBC", Slot = "13")]
		private void TrackLevelEvent(int? level, IDictionary<string, string> eventParams)
		{
		}

		// Token: 0x06007529 RID: 29993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007529")]
		[Address(RVA = "0xBEBD", Offset = "0xBEBD", VA = "0xBEBD", Slot = "14")]
		private void TrackLoginEvent(string userId, string vkConnectId, IDictionary<string, string> eventParams)
		{
		}

		// Token: 0x0600752A RID: 29994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600752A")]
		[Address(RVA = "0xBEBE", Offset = "0xBEBE", VA = "0xBEBE", Slot = "15")]
		private void TrackRegistrationEvent(string userId, string vkConnectId, IDictionary<string, string> eventParams)
		{
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600752B")]
		[Address(RVA = "0xBEBF", Offset = "0xBEBF", VA = "0xBEBF", Slot = "16")]
		private void TrackAdEvent(AdEvent adEvent)
		{
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600752C")]
		[Address(RVA = "0xBEC0", Offset = "0xBEC0", VA = "0xBEC0", Slot = "6")]
		private string GetInstanceId()
		{
			return null;
		}

		// Token: 0x0600752D RID: 29997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600752D")]
		[Address(RVA = "0xBEC1", Offset = "0xBEC1", VA = "0xBEC1")]
		public Tracker()
		{
		}

		// Token: 0x04003D40 RID: 15680
		[Token(Token = "0x4003D40")]
		[FieldOffset(Offset = "0x0")]
		public static ITracker Instance;
	}
}
