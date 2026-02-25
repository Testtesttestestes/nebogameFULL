using System;
using AssetContent.Loaders;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003BC RID: 956
	[Token(Token = "0x20003BC")]
	public class ClanNickCultIndexView : MonoBehaviour
	{
		// Token: 0x170003BC RID: 956
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600166B RID: 5739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BC")]
		public string Nick
		{
			[Token(Token = "0x600166A")]
			[Address(RVA = "0x682B", Offset = "0x682B", VA = "0x682B")]
			get
			{
				return null;
			}
			[Token(Token = "0x600166B")]
			[Address(RVA = "0x682C", Offset = "0x682C", VA = "0x682C")]
			set
			{
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BD")]
		public ClanCultDic ClanCultDic
		{
			[Token(Token = "0x600166C")]
			[Address(RVA = "0x682D", Offset = "0x682D", VA = "0x682D")]
			get
			{
				return null;
			}
			[Token(Token = "0x600166D")]
			[Address(RVA = "0x682E", Offset = "0x682E", VA = "0x682E")]
			set
			{
			}
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600166E")]
		[Address(RVA = "0x682F", Offset = "0x682F", VA = "0x682F")]
		private void HandleNickChanged()
		{
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600166F")]
		[Address(RVA = "0x6830", Offset = "0x6830", VA = "0x6830")]
		private void HandleClanCultChanged()
		{
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001670")]
		[Address(RVA = "0x6831", Offset = "0x6831", VA = "0x6831")]
		public ClanNickCultIndexView()
		{
		}

		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CultView2 _clanCultView;

		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4000BC7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImageLoader _titleBackgound;

		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		[FieldOffset(Offset = "0x1C")]
		private string _nick;

		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4000BC9")]
		[FieldOffset(Offset = "0x20")]
		private ClanCultDic _clanCultDic;
	}
}
