using System;
using System.Runtime.CompilerServices;
using Animations;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace AssetContent
{
	// Token: 0x02000E27 RID: 3623
	[Token(Token = "0x2000E27")]
	public class GameAnimatedButton : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IGameAssetContent
	{
		// Token: 0x1400020D RID: 525
		// (add) Token: 0x06005863 RID: 22627 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005864 RID: 22628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400020D")]
		public event Action<GameAnimatedButton> ClickEvent
		{
			[Token(Token = "0x6005863")]
			[Address(RVA = "0xA5D1", Offset = "0xA5D1", VA = "0xA5D1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005864")]
			[Address(RVA = "0x1DF5", Offset = "0x1DF5", VA = "0x1DF5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x06005865 RID: 22629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011F8")]
		public GameAnimationView GameAnimationView
		{
			[Token(Token = "0x6005865")]
			[Address(RVA = "0xA5D2", Offset = "0xA5D2", VA = "0xA5D2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005866 RID: 22630 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005866")]
		[Address(RVA = "0xA5D3", Offset = "0xA5D3", VA = "0xA5D3")]
		private SpineUiButtonAnimation GetButtonAnimation()
		{
			return null;
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x06005867 RID: 22631 RVA: 0x0000FB10 File Offset: 0x0000DD10
		// (set) Token: 0x06005868 RID: 22632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011F9")]
		public bool UseAnimationHitArea
		{
			[Token(Token = "0x6005867")]
			[Address(RVA = "0xA5D4", Offset = "0xA5D4", VA = "0xA5D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005868")]
			[Address(RVA = "0xA5D5", Offset = "0xA5D5", VA = "0xA5D5")]
			set
			{
			}
		}

		// Token: 0x06005869 RID: 22633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005869")]
		[Address(RVA = "0xA5D6", Offset = "0xA5D6", VA = "0xA5D6")]
		private void GameAnimationViewOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586A")]
		[Address(RVA = "0xA5D7", Offset = "0xA5D7", VA = "0xA5D7")]
		private void ValidateHitArea()
		{
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x0600586B RID: 22635 RVA: 0x0000FB28 File Offset: 0x0000DD28
		// (set) Token: 0x0600586C RID: 22636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011FA")]
		public bool Enabled
		{
			[Token(Token = "0x600586B")]
			[Address(RVA = "0xA5D8", Offset = "0xA5D8", VA = "0xA5D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600586C")]
			[Address(RVA = "0x1E0C", Offset = "0x1E0C", VA = "0x1E0C")]
			set
			{
			}
		}

		// Token: 0x0600586D RID: 22637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586D")]
		[Address(RVA = "0xA5D9", Offset = "0xA5D9", VA = "0xA5D9")]
		private void ValidateEnabled()
		{
		}

		// Token: 0x0600586E RID: 22638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586E")]
		[Address(RVA = "0xA5DA", Offset = "0xA5DA", VA = "0xA5DA")]
		private void Awake()
		{
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586F")]
		[Address(RVA = "0xA5DB", Offset = "0xA5DB", VA = "0xA5DB", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005870")]
		[Address(RVA = "0xA5DC", Offset = "0xA5DC", VA = "0xA5DC", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06005871 RID: 22641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005871")]
		[Address(RVA = "0xA5DD", Offset = "0xA5DD", VA = "0xA5DD", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x06005872 RID: 22642 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005873 RID: 22643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011FB")]
		public string AssetId
		{
			[Token(Token = "0x6005872")]
			[Address(RVA = "0xA5DE", Offset = "0xA5DE", VA = "0xA5DE", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005873")]
			[Address(RVA = "0xA5DF", Offset = "0xA5DF", VA = "0xA5DF", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06005874 RID: 22644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011FC")]
		public string AssetPath
		{
			[Token(Token = "0x6005874")]
			[Address(RVA = "0xA5E0", Offset = "0xA5E0", VA = "0xA5E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005875")]
		[Address(RVA = "0xA5E1", Offset = "0xA5E1", VA = "0xA5E1")]
		public GameAnimatedButton()
		{
		}

		// Token: 0x04002FD7 RID: 12247
		[Token(Token = "0x4002FD7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAnimationView _gameAnimationView;

		// Token: 0x04002FD8 RID: 12248
		[Token(Token = "0x4002FD8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RawImage _rawImage;

		// Token: 0x04002FDA RID: 12250
		[Token(Token = "0x4002FDA")]
		[FieldOffset(Offset = "0x1C")]
		private bool _enabled;

		// Token: 0x04002FDB RID: 12251
		[Token(Token = "0x4002FDB")]
		[FieldOffset(Offset = "0x1D")]
		private bool _useAnimationHitArea;
	}
}
