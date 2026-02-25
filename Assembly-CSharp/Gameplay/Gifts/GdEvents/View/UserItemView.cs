using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core.Data;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Gifts.GdEvents.View
{
	// Token: 0x02000712 RID: 1810
	[Token(Token = "0x2000712")]
	public class UserItemView : MonoBehaviour
	{
		// Token: 0x1400015E RID: 350
		// (add) Token: 0x06002B4F RID: 11087 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002B50 RID: 11088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400015E")]
		public event Action<UserData> SelectEvent
		{
			[Token(Token = "0x6002B4F")]
			[Address(RVA = "0x7BE9", Offset = "0x7BE9", VA = "0x7BE9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002B50")]
			[Address(RVA = "0x7BEA", Offset = "0x7BEA", VA = "0x7BEA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000846")]
		public UserData Data
		{
			[Token(Token = "0x6002B51")]
			[Address(RVA = "0x7BEB", Offset = "0x7BEB", VA = "0x7BEB")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B52")]
		[Address(RVA = "0x7BEC", Offset = "0x7BEC", VA = "0x7BEC")]
		public void SetData(UserData user)
		{
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B53")]
		[Address(RVA = "0x7BED", Offset = "0x7BED", VA = "0x7BED")]
		private void Awake()
		{
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B54")]
		[Address(RVA = "0x7BEE", Offset = "0x7BEE", VA = "0x7BEE")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B55")]
		[Address(RVA = "0x7BEF", Offset = "0x7BEF", VA = "0x7BEF")]
		private void Call()
		{
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B56")]
		[Address(RVA = "0x7BF0", Offset = "0x7BF0", VA = "0x7BF0")]
		public void SetButtonEnabled(bool value)
		{
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B57")]
		[Address(RVA = "0x7BF1", Offset = "0x7BF1", VA = "0x7BF1")]
		public UserItemView()
		{
		}

		// Token: 0x040017BB RID: 6075
		[Token(Token = "0x40017BB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AprViewSmall _apr;

		// Token: 0x040017BC RID: 6076
		[Token(Token = "0x40017BC")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _nick;

		// Token: 0x040017BD RID: 6077
		[Token(Token = "0x40017BD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImageLoader _cult;

		// Token: 0x040017BE RID: 6078
		[Token(Token = "0x40017BE")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _button;

		// Token: 0x040017C0 RID: 6080
		[Token(Token = "0x40017C0")]
		[FieldOffset(Offset = "0x24")]
		public UserData _data;
	}
}
