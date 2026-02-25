using System;
using System.Runtime.CompilerServices;
using Core;
using Core.Animations;
using Core.Materials;
using Il2CppDummyDll;
using UnityEngine;

namespace AssetContent
{
	// Token: 0x02000E28 RID: 3624
	[Token(Token = "0x2000E28")]
	[DisallowMultipleComponent]
	public class GameAnimationView : MonoBehaviour, IAsyncLoadableContent, IGameAssetContent, IGrayscalable
	{
		// Token: 0x1400020E RID: 526
		// (add) Token: 0x06005876 RID: 22646 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005877 RID: 22647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400020E")]
		public event Action<GameAnimationView> AnimationReadyEvent
		{
			[Token(Token = "0x6005876")]
			[Address(RVA = "0xA5E2", Offset = "0xA5E2", VA = "0xA5E2")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005877")]
			[Address(RVA = "0xA5E3", Offset = "0xA5E3", VA = "0xA5E3")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400020F RID: 527
		// (add) Token: 0x06005878 RID: 22648 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005879 RID: 22649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400020F")]
		public event Action<GameAnimationView> AnimationCompleteEvent
		{
			[Token(Token = "0x6005878")]
			[Address(RVA = "0xA5E4", Offset = "0xA5E4", VA = "0xA5E4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005879")]
			[Address(RVA = "0xA5E5", Offset = "0xA5E5", VA = "0xA5E5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000210 RID: 528
		// (add) Token: 0x0600587A RID: 22650 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600587B RID: 22651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000210")]
		public event Action ClickEvent
		{
			[Token(Token = "0x600587A")]
			[Address(RVA = "0xA5E6", Offset = "0xA5E6", VA = "0xA5E6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600587B")]
			[Address(RVA = "0xA5E7", Offset = "0xA5E7", VA = "0xA5E7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000211 RID: 529
		// (add) Token: 0x0600587C RID: 22652 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600587D RID: 22653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000211")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x600587C")]
			[Address(RVA = "0xA5E8", Offset = "0xA5E8", VA = "0xA5E8", Slot = "5")]
			add
			{
			}
			[Token(Token = "0x600587D")]
			[Address(RVA = "0xA5E9", Offset = "0xA5E9", VA = "0xA5E9", Slot = "6")]
			remove
			{
			}
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x0600587E RID: 22654 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011FD")]
		public IGameAnimation CurrentAnimation
		{
			[Token(Token = "0x600587E")]
			[Address(RVA = "0xA5EA", Offset = "0xA5EA", VA = "0xA5EA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x0600587F RID: 22655 RVA: 0x0000FB40 File Offset: 0x0000DD40
		// (set) Token: 0x06005880 RID: 22656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011FE")]
		public bool IsReady
		{
			[Token(Token = "0x600587F")]
			[Address(RVA = "0xA5EB", Offset = "0xA5EB", VA = "0xA5EB", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005880")]
			[Address(RVA = "0xA5EC", Offset = "0xA5EC", VA = "0xA5EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x06005881 RID: 22657 RVA: 0x0000FB58 File Offset: 0x0000DD58
		// (set) Token: 0x06005882 RID: 22658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011FF")]
		public bool Loop
		{
			[Token(Token = "0x6005881")]
			[Address(RVA = "0xA5ED", Offset = "0xA5ED", VA = "0xA5ED")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005882")]
			[Address(RVA = "0xA5EE", Offset = "0xA5EE", VA = "0xA5EE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06005883 RID: 22659 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005884 RID: 22660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001200")]
		public string AssetPath
		{
			[Token(Token = "0x6005883")]
			[Address(RVA = "0xA5EF", Offset = "0xA5EF", VA = "0xA5EF", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005884")]
			[Address(RVA = "0xA5F0", Offset = "0xA5F0", VA = "0xA5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06005885 RID: 22661 RVA: 0x0000FB70 File Offset: 0x0000DD70
		// (set) Token: 0x06005886 RID: 22662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001201")]
		public bool Interactable
		{
			[Token(Token = "0x6005885")]
			[Address(RVA = "0xA5F1", Offset = "0xA5F1", VA = "0xA5F1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005886")]
			[Address(RVA = "0xA5F2", Offset = "0xA5F2", VA = "0xA5F2")]
			set
			{
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06005887 RID: 22663 RVA: 0x0000FB88 File Offset: 0x0000DD88
		// (set) Token: 0x06005888 RID: 22664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001202")]
		public int SortingOrder
		{
			[Token(Token = "0x6005887")]
			[Address(RVA = "0xA5F3", Offset = "0xA5F3", VA = "0xA5F3")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005888")]
			[Address(RVA = "0xA5F4", Offset = "0xA5F4", VA = "0xA5F4")]
			set
			{
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x06005889 RID: 22665 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		// (set) Token: 0x0600588A RID: 22666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001203")]
		public int SortingLayerId
		{
			[Token(Token = "0x6005889")]
			[Address(RVA = "0xA5F5", Offset = "0xA5F5", VA = "0xA5F5")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600588A")]
			[Address(RVA = "0xA5F6", Offset = "0xA5F6", VA = "0xA5F6")]
			set
			{
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x0600588B RID: 22667 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600588C RID: 22668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001204")]
		public string AssetId
		{
			[Token(Token = "0x600588B")]
			[Address(RVA = "0xA5F7", Offset = "0xA5F7", VA = "0xA5F7", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600588C")]
			[Address(RVA = "0x1F57", Offset = "0x1F57", VA = "0x1F57", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600588D")]
		[Address(RVA = "0xA5F8", Offset = "0xA5F8", VA = "0xA5F8")]
		private void ClearAnimation()
		{
		}

		// Token: 0x0600588E RID: 22670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600588E")]
		[Address(RVA = "0xA5F9", Offset = "0xA5F9", VA = "0xA5F9")]
		private void FailCallback(string resourceUrl)
		{
		}

		// Token: 0x0600588F RID: 22671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600588F")]
		[Address(RVA = "0xA5FA", Offset = "0xA5FA", VA = "0xA5FA")]
		private void CompleteCallback(IGameAnimation iGameAnimation, string resourceUrl)
		{
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005890")]
		[Address(RVA = "0xA5FB", Offset = "0xA5FB", VA = "0xA5FB")]
		private void CurrentAnimationOnCompleteEvent(IGameAnimation obj)
		{
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005891")]
		[Address(RVA = "0xA5FC", Offset = "0xA5FC", VA = "0xA5FC")]
		private void CurrentAnimationOnClickEvent(IGameAnimation obj)
		{
		}

		// Token: 0x06005892 RID: 22674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005892")]
		[Address(RVA = "0xA5FD", Offset = "0xA5FD", VA = "0xA5FD")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005893 RID: 22675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005893")]
		[Address(RVA = "0xA5FE", Offset = "0xA5FE", VA = "0xA5FE")]
		public void PlayAnimation(string state)
		{
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005894")]
		[Address(RVA = "0xA5FF", Offset = "0xA5FF", VA = "0xA5FF", Slot = "10")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005895")]
		[Address(RVA = "0xA600", Offset = "0xA600", VA = "0xA600")]
		public GameAnimationView()
		{
		}

		// Token: 0x04002FDF RID: 12255
		[Token(Token = "0x4002FDF")]
		[FieldOffset(Offset = "0x1C")]
		private bool _interactable;

		// Token: 0x04002FE0 RID: 12256
		[Token(Token = "0x4002FE0")]
		[FieldOffset(Offset = "0x1D")]
		private bool _isDestroyed;

		// Token: 0x04002FE1 RID: 12257
		[Token(Token = "0x4002FE1")]
		[FieldOffset(Offset = "0x20")]
		private float? _grayscale;

		// Token: 0x04002FE2 RID: 12258
		[Token(Token = "0x4002FE2")]
		[FieldOffset(Offset = "0x28")]
		private int _sortingLayerId;

		// Token: 0x04002FE3 RID: 12259
		[Token(Token = "0x4002FE3")]
		[FieldOffset(Offset = "0x2C")]
		private int _sortingOrder;

		// Token: 0x04002FE4 RID: 12260
		[Token(Token = "0x4002FE4")]
		[FieldOffset(Offset = "0x30")]
		private string _animationState;

		// Token: 0x04002FE5 RID: 12261
		[Token(Token = "0x4002FE5")]
		[FieldOffset(Offset = "0x34")]
		private string _assetId;

		// Token: 0x04002FE6 RID: 12262
		[Token(Token = "0x4002FE6")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _currentAnimationGameObject;

		// Token: 0x04002FE7 RID: 12263
		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0x3C")]
		private IGameAnimation _currentAnimation;

		// Token: 0x04002FE8 RID: 12264
		[Token(Token = "0x4002FE8")]
		[FieldOffset(Offset = "0x40")]
		private IGrayscalable _grayscalable;
	}
}
