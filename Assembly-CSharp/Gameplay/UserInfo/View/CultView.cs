using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F3 RID: 1011
	[Token(Token = "0x20003F3")]
	public class CultView : MonoBehaviour
	{
		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017C0 RID: 6080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000423")]
		public CultDic CultDic
		{
			[Token(Token = "0x60017BF")]
			[Address(RVA = "0x697A", Offset = "0x697A", VA = "0x697A")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017C0")]
			[Address(RVA = "0x697B", Offset = "0x697B", VA = "0x697B")]
			set
			{
			}
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C1")]
		[Address(RVA = "0x697C", Offset = "0x697C", VA = "0x697C", Slot = "4")]
		protected virtual void HandleCultDicChanged()
		{
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C2")]
		[Address(RVA = "0x697D", Offset = "0x697D", VA = "0x697D")]
		public void SetIconAssetId(string assetId)
		{
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C3")]
		[Address(RVA = "0x697E", Offset = "0x697E", VA = "0x697E")]
		public CultView()
		{
		}

		// Token: 0x04000C9C RID: 3228
		[Token(Token = "0x4000C9C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04000C9D RID: 3229
		[Token(Token = "0x4000C9D")]
		[FieldOffset(Offset = "0x14")]
		private CultDic _cultDic;
	}
}
