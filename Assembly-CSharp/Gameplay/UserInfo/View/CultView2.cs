using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F4 RID: 1012
	[Token(Token = "0x20003F4")]
	public class CultView2 : MonoBehaviour
	{
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000424")]
		public CultDic CultDic
		{
			[Token(Token = "0x60017C4")]
			[Address(RVA = "0x697F", Offset = "0x697F", VA = "0x697F")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017C5")]
			[Address(RVA = "0x6980", Offset = "0x6980", VA = "0x6980")]
			set
			{
			}
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x6981", Offset = "0x6981", VA = "0x6981", Slot = "4")]
		protected virtual void HandleCultDicChanged()
		{
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x6982", Offset = "0x6982", VA = "0x6982")]
		public void SetIconAssetId(string assetId)
		{
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x6983", Offset = "0x6983", VA = "0x6983")]
		public CultView2()
		{
		}

		// Token: 0x04000C9E RID: 3230
		[Token(Token = "0x4000C9E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _image;

		// Token: 0x04000C9F RID: 3231
		[Token(Token = "0x4000C9F")]
		[FieldOffset(Offset = "0x14")]
		private CultDic _cultDic;
	}
}
