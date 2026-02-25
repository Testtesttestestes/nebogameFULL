using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Mycom.Tracker.Unity.Ads;

namespace Mycom.Tracker.Unity.Internal.Interfaces
{
	// Token: 0x02001346 RID: 4934
	[Token(Token = "0x2001346")]
	internal interface ITracker : IDisposable
	{
		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x060074E4 RID: 29924
		[Token(Token = "0x1700179D")]
		MyTrackerParams MyTrackerParams { [Token(Token = "0x60074E4")] get; }

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x060074E5 RID: 29925
		[Token(Token = "0x1700179E")]
		MyTrackerConfig MyTrackerConfig { [Token(Token = "0x60074E5")] get; }

		// Token: 0x060074E6 RID: 29926
		[Token(Token = "0x60074E6")]
		string GetInstanceId();

		// Token: 0x060074E7 RID: 29927
		[Token(Token = "0x60074E7")]
		void Init(string id);

		// Token: 0x060074E8 RID: 29928
		[Token(Token = "0x60074E8")]
		bool IsDebugMode();

		// Token: 0x060074E9 RID: 29929
		[Token(Token = "0x60074E9")]
		void SetAttributionListener(Action<MyTrackerAttribution> listener);

		// Token: 0x060074EA RID: 29930
		[Token(Token = "0x60074EA")]
		void SetDebugMode(bool value);

		// Token: 0x060074EB RID: 29931
		[Token(Token = "0x60074EB")]
		void TrackEvent(string name, [Optional] IDictionary<string, string> eventParams);

		// Token: 0x060074EC RID: 29932
		[Token(Token = "0x60074EC")]
		void TrackInviteEvent([Optional] IDictionary<string, string> eventParams);

		// Token: 0x060074ED RID: 29933
		[Token(Token = "0x60074ED")]
		void TrackLevelEvent([Optional] int? level, [Optional] IDictionary<string, string> eventParams);

		// Token: 0x060074EE RID: 29934
		[Token(Token = "0x60074EE")]
		void TrackLoginEvent(string userId, string vkConnectId, [Optional] IDictionary<string, string> eventParams);

		// Token: 0x060074EF RID: 29935
		[Token(Token = "0x60074EF")]
		void TrackRegistrationEvent(string userId, string vkConnectId, [Optional] IDictionary<string, string> eventParams);

		// Token: 0x060074F0 RID: 29936
		[Token(Token = "0x60074F0")]
		void TrackAdEvent(AdEvent adEvent);

		// Token: 0x060074F1 RID: 29937
		[Token(Token = "0x60074F1")]
		void Flush();
	}
}
