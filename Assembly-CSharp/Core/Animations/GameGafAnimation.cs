using System;
using System.Runtime.CompilerServices;
using Core.Materials;
using GAF.Core;
using GAFInternal.Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Core.Animations
{
	// Token: 0x02001279 RID: 4729
	[Token(Token = "0x2001279")]
	[RequireComponent(typeof(GAFBakedMovieClip))]
	public class GameGafAnimation : MonoBehaviour, IGameAnimation, IPointerClickHandler, IEventSystemHandler, IGrayscalable
	{
		// Token: 0x06007030 RID: 28720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007030")]
		[Address(RVA = "0xBA75", Offset = "0xBA75", VA = "0xBA75")]
		private void Awake()
		{
		}

		// Token: 0x140002FB RID: 763
		// (add) Token: 0x06007031 RID: 28721 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007032 RID: 28722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002FB")]
		public event Action<IGameAnimation> ClickEvent
		{
			[Token(Token = "0x6007031")]
			[Address(RVA = "0xBA76", Offset = "0xBA76", VA = "0xBA76", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007032")]
			[Address(RVA = "0xBA77", Offset = "0xBA77", VA = "0xBA77", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06007033 RID: 28723 RVA: 0x000145B0 File Offset: 0x000127B0
		// (set) Token: 0x06007034 RID: 28724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016E4")]
		public bool Interactable
		{
			[Token(Token = "0x6007033")]
			[Address(RVA = "0xBA78", Offset = "0xBA78", VA = "0xBA78", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007034")]
			[Address(RVA = "0xBA79", Offset = "0xBA79", VA = "0xBA79", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06007035 RID: 28725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016E5")]
		public MonoBehaviour MonoBehaviour
		{
			[Token(Token = "0x6007035")]
			[Address(RVA = "0xBA7A", Offset = "0xBA7A", VA = "0xBA7A", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06007036 RID: 28726 RVA: 0x000145C8 File Offset: 0x000127C8
		// (set) Token: 0x06007037 RID: 28727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016E6")]
		public int SortingLayerId
		{
			[Token(Token = "0x6007036")]
			[Address(RVA = "0xBA7B", Offset = "0xBA7B", VA = "0xBA7B", Slot = "11")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007037")]
			[Address(RVA = "0xBA7C", Offset = "0xBA7C", VA = "0xBA7C", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x140002FC RID: 764
		// (add) Token: 0x06007038 RID: 28728 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007039 RID: 28729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002FC")]
		public event Action<IGameAnimation> CompleteEvent
		{
			[Token(Token = "0x6007038")]
			[Address(RVA = "0xBA7D", Offset = "0xBA7D", VA = "0xBA7D", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007039")]
			[Address(RVA = "0xBA7E", Offset = "0xBA7E", VA = "0xBA7E", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x0600703A RID: 28730 RVA: 0x000145E0 File Offset: 0x000127E0
		// (set) Token: 0x0600703B RID: 28731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016E7")]
		public int SortingOrder
		{
			[Token(Token = "0x600703A")]
			[Address(RVA = "0xBA7F", Offset = "0xBA7F", VA = "0xBA7F", Slot = "13")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600703B")]
			[Address(RVA = "0xBA80", Offset = "0xBA80", VA = "0xBA80", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x0600703C RID: 28732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600703C")]
		[Address(RVA = "0xBA81", Offset = "0xBA81", VA = "0xBA81", Slot = "16")]
		public void Play(bool loop)
		{
		}

		// Token: 0x0600703D RID: 28733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600703D")]
		[Address(RVA = "0xBA82", Offset = "0xBA82", VA = "0xBA82")]
		private void OnMovieClipCompleteHandler(IGAFMovieClip obj)
		{
		}

		// Token: 0x0600703E RID: 28734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600703E")]
		[Address(RVA = "0xBA83", Offset = "0xBA83", VA = "0xBA83", Slot = "17")]
		public void Stop()
		{
		}

		// Token: 0x0600703F RID: 28735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600703F")]
		[Address(RVA = "0xBA84", Offset = "0xBA84", VA = "0xBA84", Slot = "19")]
		public void Pause()
		{
		}

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06007040 RID: 28736 RVA: 0x000145F8 File Offset: 0x000127F8
		// (set) Token: 0x06007041 RID: 28737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016E8")]
		public bool Loop
		{
			[Token(Token = "0x6007040")]
			[Address(RVA = "0xBA85", Offset = "0xBA85", VA = "0xBA85", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007041")]
			[Address(RVA = "0xBA86", Offset = "0xBA86", VA = "0xBA86")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007042 RID: 28738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007042")]
		[Address(RVA = "0xBA87", Offset = "0xBA87", VA = "0xBA87", Slot = "18")]
		public void Play(string state, bool loop)
		{
		}

		// Token: 0x06007043 RID: 28739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007043")]
		[Address(RVA = "0xBA88", Offset = "0xBA88", VA = "0xBA88", Slot = "20")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06007044 RID: 28740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007044")]
		[Address(RVA = "0xBA89", Offset = "0xBA89", VA = "0xBA89", Slot = "21")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x06007045 RID: 28741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007045")]
		[Address(RVA = "0xBA8A", Offset = "0xBA8A", VA = "0xBA8A")]
		public GameGafAnimation()
		{
		}

		// Token: 0x04003A8B RID: 14987
		[Token(Token = "0x4003A8B")]
		[FieldOffset(Offset = "0x10")]
		private GAFBakedMovieClip _bakedMovieClip;

		// Token: 0x04003A8E RID: 14990
		[Token(Token = "0x4003A8E")]
		[FieldOffset(Offset = "0x1C")]
		private int _sortingLayerId;
	}
}
