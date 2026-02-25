using System;
using AssetContent.Loaders;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x02000408 RID: 1032
	[Token(Token = "0x2000408")]
	public class UserNickCultLevelExpView : MonoBehaviour
	{
		// Token: 0x0600183C RID: 6204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183C")]
		[Address(RVA = "0x69F0", Offset = "0x69F0", VA = "0x69F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000449")]
		public UserData User
		{
			[Token(Token = "0x600183D")]
			[Address(RVA = "0x69F1", Offset = "0x69F1", VA = "0x69F1")]
			get
			{
				return null;
			}
			[Token(Token = "0x600183E")]
			[Address(RVA = "0x69F2", Offset = "0x69F2", VA = "0x69F2")]
			set
			{
			}
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x69F3", Offset = "0x69F3", VA = "0x69F3")]
		private void HandleUserChanged(UserData fromUser, UserData toUser)
		{
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x69F4", Offset = "0x69F4", VA = "0x69F4")]
		private void HadleOnUserCultChangedEvent(CultDic cult)
		{
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x69F5", Offset = "0x69F5", VA = "0x69F5")]
		private void HandleOnUserNickChangedEvent()
		{
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001842")]
		[Address(RVA = "0x69F6", Offset = "0x69F6", VA = "0x69F6")]
		private void HandleOnUserLevelChangedEvent()
		{
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001843")]
		[Address(RVA = "0x69F7", Offset = "0x69F7", VA = "0x69F7")]
		private void HandleOnUserExperienceChangedEvent()
		{
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001844")]
		[Address(RVA = "0x69F8", Offset = "0x69F8", VA = "0x69F8")]
		public void SetLevel(uint value)
		{
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001845")]
		[Address(RVA = "0x69F9", Offset = "0x69F9", VA = "0x69F9")]
		public void SetExperienceProgress(float value)
		{
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001846")]
		[Address(RVA = "0x69FA", Offset = "0x69FA", VA = "0x69FA")]
		public void SetNick(string value)
		{
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x69FB", Offset = "0x69FB", VA = "0x69FB")]
		public void SetCult(CultDic value)
		{
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x69FC", Offset = "0x69FC", VA = "0x69FC")]
		public void Init(UserData user, UserManager userManager)
		{
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x69FD", Offset = "0x69FD", VA = "0x69FD")]
		public UserNickCultLevelExpView()
		{
		}

		// Token: 0x04000CF7 RID: 3319
		[Token(Token = "0x4000CF7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x04000CF8 RID: 3320
		[Token(Token = "0x4000CF8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LevelView _levelView;

		// Token: 0x04000CF9 RID: 3321
		[Token(Token = "0x4000CF9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RankView _rankView;

		// Token: 0x04000CFA RID: 3322
		[Token(Token = "0x4000CFA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CultView2 _cultView;

		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImageLoader _nickBackground;

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0x24")]
		[Header("Optional")]
		[SerializeField]
		private GameRawImageLoader _cultDecorForAvator;

		// Token: 0x04000CFD RID: 3325
		[Token(Token = "0x4000CFD")]
		[FieldOffset(Offset = "0x28")]
		private UserManager _userManager;

		// Token: 0x04000CFE RID: 3326
		[Token(Token = "0x4000CFE")]
		[FieldOffset(Offset = "0x2C")]
		private UserData _user;
	}
}
