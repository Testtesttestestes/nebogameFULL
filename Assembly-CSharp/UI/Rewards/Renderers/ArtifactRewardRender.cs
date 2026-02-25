using System;
using System.Collections.Generic;
using System.Threading;
using Animations;
using Core.Data;
using Cysharp.Threading.Tasks;
using Gameplay.ArtifactDrop.View;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Rewards.Renderers
{
	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	public class ArtifactRewardRender : AbstractRewardRender
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000180")]
		public Button TakeAllBtn
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x5E89", Offset = "0x5E89", VA = "0x5E89")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000181")]
		public Button SellAllBtn
		{
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x5E8A", Offset = "0x5E8A", VA = "0x5E8A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x5E8B", Offset = "0x5E8B", VA = "0x5E8B", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x5E8C", Offset = "0x5E8C", VA = "0x5E8C", Slot = "10")]
		protected virtual ArtikulData CreateArtikul(int index, uint artikulId)
		{
			return null;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x5E8D", Offset = "0x5E8D", VA = "0x5E8D")]
		private void HandleOnDestroyEvent()
		{
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x5E8E", Offset = "0x5E8E", VA = "0x5E8E")]
		public void SetArtifacts(params ArtifactData[] artifacts)
		{
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x5E8F", Offset = "0x5E8F", VA = "0x5E8F")]
		public void RemoveAll(IAnimationProvider provider)
		{
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x5E90", Offset = "0x5E90", VA = "0x5E90")]
		private UniTask RemoveAllAsync(IAnimationProvider provider, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x5E91", Offset = "0x5E91", VA = "0x5E91")]
		public void Remove(ArtifactData artifactData, IAnimationProvider provider)
		{
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x5E92", Offset = "0x5E92", VA = "0x5E92")]
		private UniTask RemoveAsync(ArtifactData artifactData, IAnimationProvider provider, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x5E93", Offset = "0x5E93", VA = "0x5E93", Slot = "11")]
		protected virtual void ValidateVisibleButtons()
		{
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x5E94", Offset = "0x5E94", VA = "0x5E94", Slot = "9")]
		public override void Dispose()
		{
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x5E95", Offset = "0x5E95", VA = "0x5E95")]
		public ArtifactRewardRender()
		{
		}

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArtikulView ArtikulPrefab;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameObject FAQPrefab;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject LockPrefab;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ArtifactView ArtifactPrefab;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TakeSellAllButtonsView _buttonsPrefab;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x3C")]
		protected TakeSellAllButtonsView _buttons;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x40")]
		private ArtifactViewAnimationHandler _animationHandler;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x44")]
		private CancellationTokenSource _cancellationSource;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x48")]
		protected readonly List<ArtifactView> _currentArtifacts;
	}
}
