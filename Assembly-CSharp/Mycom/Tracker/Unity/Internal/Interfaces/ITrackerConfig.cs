using System;
using Il2CppDummyDll;

namespace Mycom.Tracker.Unity.Internal.Interfaces
{
	// Token: 0x02001347 RID: 4935
	[Token(Token = "0x2001347")]
	internal interface ITrackerConfig : IDisposable
	{
		// Token: 0x060074F2 RID: 29938
		[Token(Token = "0x60074F2")]
		string GetId();

		// Token: 0x060074F3 RID: 29939
		[Token(Token = "0x60074F3")]
		int GetBufferingPeriod();

		// Token: 0x060074F4 RID: 29940
		[Token(Token = "0x60074F4")]
		void SetBufferingPeriod(int value);

		// Token: 0x060074F5 RID: 29941
		[Token(Token = "0x60074F5")]
		int GetForcingPeriod();

		// Token: 0x060074F6 RID: 29942
		[Token(Token = "0x60074F6")]
		void SetForcingPeriod(int value);

		// Token: 0x060074F7 RID: 29943
		[Token(Token = "0x60074F7")]
		int GetLaunchTimeout();

		// Token: 0x060074F8 RID: 29944
		[Token(Token = "0x60074F8")]
		void SetLaunchTimeout(int value);

		// Token: 0x060074F9 RID: 29945
		[Token(Token = "0x60074F9")]
		bool IsTrackingEnvironmentEnabled();

		// Token: 0x060074FA RID: 29946
		[Token(Token = "0x60074FA")]
		void SetTrackingEnvironmentEnabled(bool value);

		// Token: 0x060074FB RID: 29947
		[Token(Token = "0x60074FB")]
		bool IsTrackingLaunchEnabled();

		// Token: 0x060074FC RID: 29948
		[Token(Token = "0x60074FC")]
		void SetTrackingLaunchEnabled(bool value);

		// Token: 0x060074FD RID: 29949
		[Token(Token = "0x60074FD")]
		bool IsTrackingLocationEnabled();

		// Token: 0x060074FE RID: 29950
		[Token(Token = "0x60074FE")]
		void SetTrackingLocationEnabled(bool value);

		// Token: 0x060074FF RID: 29951
		[Token(Token = "0x60074FF")]
		void SetProxyHost(string value);

		// Token: 0x06007500 RID: 29952
		[Token(Token = "0x6007500")]
		bool IsRegisterForSkAdAttribution();

		// Token: 0x06007501 RID: 29953
		[Token(Token = "0x6007501")]
		void SetRegisterForSkAdAttribution(bool value);
	}
}
