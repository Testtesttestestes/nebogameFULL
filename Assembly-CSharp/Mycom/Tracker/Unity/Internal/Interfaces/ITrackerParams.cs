using System;
using Il2CppDummyDll;

namespace Mycom.Tracker.Unity.Internal.Interfaces
{
	// Token: 0x02001348 RID: 4936
	[Token(Token = "0x2001348")]
	internal interface ITrackerParams : IDisposable
	{
		// Token: 0x06007502 RID: 29954
		[Token(Token = "0x6007502")]
		int GetAge();

		// Token: 0x06007503 RID: 29955
		[Token(Token = "0x6007503")]
		void SetAge(int value);

		// Token: 0x06007504 RID: 29956
		[Token(Token = "0x6007504")]
		string[] GetCustomUserIds();

		// Token: 0x06007505 RID: 29957
		[Token(Token = "0x6007505")]
		void SetCustomUserIds(string[] value);

		// Token: 0x06007506 RID: 29958
		[Token(Token = "0x6007506")]
		string[] GetEmails();

		// Token: 0x06007507 RID: 29959
		[Token(Token = "0x6007507")]
		void SetEmails(string[] value);

		// Token: 0x06007508 RID: 29960
		[Token(Token = "0x6007508")]
		GenderEnum GetGender();

		// Token: 0x06007509 RID: 29961
		[Token(Token = "0x6007509")]
		void SetGender(GenderEnum value);

		// Token: 0x0600750A RID: 29962
		[Token(Token = "0x600750A")]
		string[] GetIcqIds();

		// Token: 0x0600750B RID: 29963
		[Token(Token = "0x600750B")]
		void SetIcqIds(string[] value);

		// Token: 0x0600750C RID: 29964
		[Token(Token = "0x600750C")]
		string GetLang();

		// Token: 0x0600750D RID: 29965
		[Token(Token = "0x600750D")]
		void SetLang(string value);

		// Token: 0x0600750E RID: 29966
		[Token(Token = "0x600750E")]
		string GetMrgsAppId();

		// Token: 0x0600750F RID: 29967
		[Token(Token = "0x600750F")]
		void SetMrgsAppId(string value);

		// Token: 0x06007510 RID: 29968
		[Token(Token = "0x6007510")]
		string GetMrgsId();

		// Token: 0x06007511 RID: 29969
		[Token(Token = "0x6007511")]
		void SetMrgsId(string value);

		// Token: 0x06007512 RID: 29970
		[Token(Token = "0x6007512")]
		string GetMrgsUserId();

		// Token: 0x06007513 RID: 29971
		[Token(Token = "0x6007513")]
		void SetMrgsUserId(string value);

		// Token: 0x06007514 RID: 29972
		[Token(Token = "0x6007514")]
		string[] GetOkIds();

		// Token: 0x06007515 RID: 29973
		[Token(Token = "0x6007515")]
		void SetOkIds(string[] value);

		// Token: 0x06007516 RID: 29974
		[Token(Token = "0x6007516")]
		string[] GetPhones();

		// Token: 0x06007517 RID: 29975
		[Token(Token = "0x6007517")]
		void SetPhones(string[] value);

		// Token: 0x06007518 RID: 29976
		[Token(Token = "0x6007518")]
		string[] GetVkIds();

		// Token: 0x06007519 RID: 29977
		[Token(Token = "0x6007519")]
		void SetVkIds(string[] value);

		// Token: 0x0600751A RID: 29978
		[Token(Token = "0x600751A")]
		string[] GetVkConnectIds();

		// Token: 0x0600751B RID: 29979
		[Token(Token = "0x600751B")]
		void SetVkConnectIds(string[] value);
	}
}
