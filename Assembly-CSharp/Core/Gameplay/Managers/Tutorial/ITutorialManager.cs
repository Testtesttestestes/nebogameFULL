using System;
using Core.Cache.User;
using Core.Data;
using Gameplay.Combat.View;
using Gameplay.TutorialV2.View;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.World;

namespace Core.Gameplay.Managers.Tutorial
{
	// Token: 0x02001183 RID: 4483
	[Token(Token = "0x2001183")]
	public interface ITutorialManager
	{
		// Token: 0x170015CB RID: 5579
		// (get) Token: 0x06006A76 RID: 27254
		[Token(Token = "0x170015CB")]
		IGame Game { [Token(Token = "0x6006A76")] get; }

		// Token: 0x06006A77 RID: 27255
		[Token(Token = "0x6006A77")]
		void SetView(ITutorialView view);

		// Token: 0x06006A78 RID: 27256
		[Token(Token = "0x6006A78")]
		void SetCombatView(OneOnOneCombatView view);

		// Token: 0x06006A79 RID: 27257
		[Token(Token = "0x6006A79")]
		[CanBeNull]
		UserData GetUser();

		// Token: 0x06006A7A RID: 27258
		[Token(Token = "0x6006A7A")]
		[CanBeNull]
		RepeatedField<ProtoGetUserIsleInfoAns.Types.IsleInformation> GetIsles();

		// Token: 0x06006A7B RID: 27259
		[Token(Token = "0x6006A7B")]
		void CreateUser(IUserCache user);
	}
}
