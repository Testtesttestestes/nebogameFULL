using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Clans.Office.View.ClanCreationTab
{
	// Token: 0x02000A3F RID: 2623
	[Token(Token = "0x2000A3F")]
	public class ClanTypeListElement : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x14000199 RID: 409
		// (add) Token: 0x06003E16 RID: 15894 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003E17 RID: 15895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000199")]
		public event Action<ClanTypeListElement> ClickedEvent
		{
			[Token(Token = "0x6003E16")]
			[Address(RVA = "0x8CD5", Offset = "0x8CD5", VA = "0x8CD5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003E17")]
			[Address(RVA = "0x8CD6", Offset = "0x8CD6", VA = "0x8CD6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (set) Token: 0x06003E18 RID: 15896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C70")]
		public bool Selected
		{
			[Token(Token = "0x6003E18")]
			[Address(RVA = "0x8CD7", Offset = "0x8CD7", VA = "0x8CD7")]
			set
			{
			}
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E19")]
		[Address(RVA = "0x8CD8", Offset = "0x8CD8", VA = "0x8CD8")]
		public void Init(CultDic dic)
		{
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E1A")]
		[Address(RVA = "0x8CD9", Offset = "0x8CD9", VA = "0x8CD9", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E1B")]
		[Address(RVA = "0x8CDA", Offset = "0x8CDA", VA = "0x8CDA")]
		public ClanTypeListElement()
		{
		}

		// Token: 0x040022DE RID: 8926
		[Token(Token = "0x40022DE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextMeshProUGUI _clanCultName;

		// Token: 0x040022DF RID: 8927
		[Token(Token = "0x40022DF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected GameImage _clanCultImage;

		// Token: 0x040022E0 RID: 8928
		[Token(Token = "0x40022E0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectedImage;
	}
}
