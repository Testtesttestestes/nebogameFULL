using System;
using AssetContent;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;
using UI;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D53 RID: 3411
	[Token(Token = "0x2000D53")]
	public class AprViewSmall : AbstractDataRenderer<AprDicWrapper>, IAprView, IToolTipDataProvider
	{
		// Token: 0x060053A5 RID: 21413 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60053A5")]
		[Address(RVA = "0xA164", Offset = "0xA164", VA = "0xA164", Slot = "22")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A6")]
		[Address(RVA = "0xA165", Offset = "0xA165", VA = "0xA165", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A7")]
		[Address(RVA = "0xA166", Offset = "0xA166", VA = "0xA166")]
		public AprViewSmall()
		{
		}

		// Token: 0x04002D55 RID: 11605
		[Token(Token = "0x4002D55")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameAssetViewRawImage _gameAssetView;
	}
}
