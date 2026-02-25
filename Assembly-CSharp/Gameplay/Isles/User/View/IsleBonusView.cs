using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D17 RID: 3351
	[Token(Token = "0x2000D17")]
	public class IsleBonusView : MonoBehaviour, IBoundsProvider
	{
		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x060051C7 RID: 20935 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001089")]
		public GameSpriteRendererLoaderInteractable SpriteLoader
		{
			[Token(Token = "0x60051C7")]
			[Address(RVA = "0x9FA1", Offset = "0x9FA1", VA = "0x9FA1")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x060051C8 RID: 20936 RVA: 0x0000EE38 File Offset: 0x0000D038
		// (set) Token: 0x060051C9 RID: 20937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700108A")]
		public uint BonusId
		{
			[Token(Token = "0x60051C8")]
			[Address(RVA = "0x9FA2", Offset = "0x9FA2", VA = "0x9FA2")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60051C9")]
			[Address(RVA = "0x9FA3", Offset = "0x9FA3", VA = "0x9FA3")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x060051CA RID: 20938 RVA: 0x0000EE50 File Offset: 0x0000D050
		// (set) Token: 0x060051CB RID: 20939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700108B")]
		public uint PositionId
		{
			[Token(Token = "0x60051CA")]
			[Address(RVA = "0x9FA4", Offset = "0x9FA4", VA = "0x9FA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60051CB")]
			[Address(RVA = "0x9FA5", Offset = "0x9FA5", VA = "0x9FA5")]
			set
			{
			}
		}

		// Token: 0x1700108C RID: 4236
		// (set) Token: 0x060051CC RID: 20940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700108C")]
		public Vector2 Position
		{
			[Token(Token = "0x60051CC")]
			[Address(RVA = "0x9FA6", Offset = "0x9FA6", VA = "0x9FA6")]
			set
			{
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x060051CD RID: 20941 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700108D")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x60051CD")]
			[Address(RVA = "0x9FA7", Offset = "0x9FA7", VA = "0x9FA7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051CE")]
		[Address(RVA = "0x9FA8", Offset = "0x9FA8", VA = "0x9FA8")]
		private void OnDisable()
		{
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051CF")]
		[Address(RVA = "0x9FA9", Offset = "0x9FA9", VA = "0x9FA9")]
		private void OnEnable()
		{
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051D0")]
		[Address(RVA = "0x9FAA", Offset = "0x9FAA", VA = "0x9FAA")]
		private void HandleReadyEvent(IAsyncLoadableContent content)
		{
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x060051D1 RID: 20945 RVA: 0x0000EE68 File Offset: 0x0000D068
		[Token(Token = "0x1700108E")]
		public Bounds Bounds
		{
			[Token(Token = "0x60051D1")]
			[Address(RVA = "0x9FAB", Offset = "0x9FAB", VA = "0x9FAB", Slot = "4")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051D2")]
		[Address(RVA = "0x9FAC", Offset = "0x9FAC", VA = "0x9FAC")]
		private void Awake()
		{
		}

		// Token: 0x140001F3 RID: 499
		// (add) Token: 0x060051D3 RID: 20947 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060051D4 RID: 20948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F3")]
		public event Action<IsleBonusView> ClickEvent
		{
			[Token(Token = "0x60051D3")]
			[Address(RVA = "0x9FAD", Offset = "0x9FAD", VA = "0x9FAD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051D4")]
			[Address(RVA = "0x9FAE", Offset = "0x9FAE", VA = "0x9FAE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051D5")]
		[Address(RVA = "0x9FAF", Offset = "0x9FAF", VA = "0x9FAF")]
		private void SpriteLoaderOnClickEvent()
		{
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051D6")]
		[Address(RVA = "0x9FB0", Offset = "0x9FB0", VA = "0x9FB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060051D7 RID: 20951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051D7")]
		[Address(RVA = "0x9FB1", Offset = "0x9FB1", VA = "0x9FB1")]
		public IsleBonusView()
		{
		}

		// Token: 0x04002C78 RID: 11384
		[Token(Token = "0x4002C78")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _resourceOffset;

		// Token: 0x04002C79 RID: 11385
		[Token(Token = "0x4002C79")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected GameSpriteRendererLoaderInteractable _spriteLoader;

		// Token: 0x04002C7B RID: 11387
		[Token(Token = "0x4002C7B")]
		[FieldOffset(Offset = "0x1C")]
		private uint _positionId;

		// Token: 0x04002C7C RID: 11388
		[Token(Token = "0x4002C7C")]
		[FieldOffset(Offset = "0x20")]
		private IGuideTarget _guideTarget;
	}
}
