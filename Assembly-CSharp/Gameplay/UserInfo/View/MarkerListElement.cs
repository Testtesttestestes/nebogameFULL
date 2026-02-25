using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F8 RID: 1016
	[Token(Token = "0x20003F8")]
	public class MarkerListElement : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x060017DA RID: 6106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DA")]
		[Address(RVA = "0x6995", Offset = "0x6995", VA = "0x6995")]
		public void Init(uint markerId, Dictionaries dict)
		{
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60017DB")]
		[Address(RVA = "0x6996", Offset = "0x6996", VA = "0x6996", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DC")]
		[Address(RVA = "0x6997", Offset = "0x6997", VA = "0x6997")]
		public MarkerListElement()
		{
		}

		// Token: 0x04000CA8 RID: 3240
		[Token(Token = "0x4000CA8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04000CA9 RID: 3241
		[Token(Token = "0x4000CA9")]
		[FieldOffset(Offset = "0x14")]
		private AprMarkersDic _markerDic;

		// Token: 0x04000CAA RID: 3242
		[Token(Token = "0x4000CAA")]
		[FieldOffset(Offset = "0x18")]
		private Dictionaries _dict;
	}
}
