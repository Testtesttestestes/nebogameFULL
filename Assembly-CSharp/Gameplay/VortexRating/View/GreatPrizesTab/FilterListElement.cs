using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexRating.View.GreatPrizesTab
{
	// Token: 0x0200038C RID: 908
	[Token(Token = "0x200038C")]
	public class FilterListElement : MonoBehaviour
	{
		// Token: 0x1400010B RID: 267
		// (add) Token: 0x0600151D RID: 5405 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600151E RID: 5406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400010B")]
		public event Action<FilterListElement> ClickedEvent
		{
			[Token(Token = "0x600151D")]
			[Address(RVA = "0x66DF", Offset = "0x66DF", VA = "0x66DF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600151E")]
			[Address(RVA = "0x66E0", Offset = "0x66E0", VA = "0x66E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000379")]
		public object Data
		{
			[Token(Token = "0x600151F")]
			[Address(RVA = "0x66E1", Offset = "0x66E1", VA = "0x66E1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001520")]
			[Address(RVA = "0x66E2", Offset = "0x66E2", VA = "0x66E2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700037A RID: 890
		// (set) Token: 0x06001521 RID: 5409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037A")]
		public bool Selected
		{
			[Token(Token = "0x6001521")]
			[Address(RVA = "0x66E3", Offset = "0x66E3", VA = "0x66E3")]
			set
			{
			}
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001522")]
		[Address(RVA = "0x66E4", Offset = "0x66E4", VA = "0x66E4")]
		private void Awake()
		{
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001523")]
		[Address(RVA = "0x66E5", Offset = "0x66E5", VA = "0x66E5")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001524")]
		[Address(RVA = "0x66E6", Offset = "0x66E6", VA = "0x66E6")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001525")]
		[Address(RVA = "0x66E7", Offset = "0x66E7", VA = "0x66E7")]
		public void Init(GenericListFilter.ListFilterData data)
		{
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001526")]
		[Address(RVA = "0x66E8", Offset = "0x66E8", VA = "0x66E8")]
		public FilterListElement()
		{
		}

		// Token: 0x04000B34 RID: 2868
		[Token(Token = "0x4000B34")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000B35 RID: 2869
		[Token(Token = "0x4000B35")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _selector;

		// Token: 0x04000B36 RID: 2870
		[Token(Token = "0x4000B36")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;
	}
}
