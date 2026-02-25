using System;
using CloudsFly;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.WorldView;
using Gameplay.Isles.Base.Events;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Isles.Base.View
{
	// Token: 0x02000CFC RID: 3324
	[Token(Token = "0x2000CFC")]
	public class IsleBossContainer : BaseWorldObjectRenderer
	{
		// Token: 0x06005112 RID: 20754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005112")]
		[Address(RVA = "0x9F02", Offset = "0x9F02", VA = "0x9F02")]
		public void Init(IIsle isle, BaseIsleEvents isleEvents)
		{
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005113")]
		[Address(RVA = "0x9F03", Offset = "0x9F03", VA = "0x9F03")]
		private void CurrentCreateRequestChangedEvent()
		{
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005114")]
		[Address(RVA = "0x9F04", Offset = "0x9F04", VA = "0x9F04")]
		private void CurrentBossInstanceChangedEvent(long obj)
		{
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005115")]
		[Address(RVA = "0x9F05", Offset = "0x9F05", VA = "0x9F05")]
		private void IsCurrentChangedEvent()
		{
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005116")]
		[Address(RVA = "0x9F06", Offset = "0x9F06", VA = "0x9F06")]
		private void ValidateBoss()
		{
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005117")]
		[Address(RVA = "0x9F07", Offset = "0x9F07", VA = "0x9F07")]
		public void Deinit()
		{
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005118")]
		[Address(RVA = "0x9F08", Offset = "0x9F08", VA = "0x9F08")]
		private void Clear()
		{
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005119")]
		[Address(RVA = "0x9F09", Offset = "0x9F09", VA = "0x9F09")]
		public void ShowBoss(BossInstance instance)
		{
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511A")]
		[Address(RVA = "0x9F0A", Offset = "0x9F0A", VA = "0x9F0A")]
		public void CreateBossRequestView(BossCreateRequestData data)
		{
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511B")]
		[Address(RVA = "0x9F0B", Offset = "0x9F0B", VA = "0x9F0B", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511C")]
		[Address(RVA = "0x9F0C", Offset = "0x9F0C", VA = "0x9F0C", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511D")]
		[Address(RVA = "0x9F0D", Offset = "0x9F0D", VA = "0x9F0D")]
		public IsleBossContainer()
		{
		}

		// Token: 0x04002C29 RID: 11305
		[Token(Token = "0x4002C29")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private IsleBossView _bossWorldViewPrefab;

		// Token: 0x04002C2A RID: 11306
		[Token(Token = "0x4002C2A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private IsleBossCreateRequestView _bossCreateRequestViewPrefab;

		// Token: 0x04002C2B RID: 11307
		[Token(Token = "0x4002C2B")]
		[FieldOffset(Offset = "0x2C")]
		private IsleBossView _bossWorldView;

		// Token: 0x04002C2C RID: 11308
		[Token(Token = "0x4002C2C")]
		[FieldOffset(Offset = "0x30")]
		private IsleBossCreateRequestView _bossCreateRequestView;

		// Token: 0x04002C2D RID: 11309
		[Token(Token = "0x4002C2D")]
		[FieldOffset(Offset = "0x34")]
		private IIsle _isle;

		// Token: 0x04002C2E RID: 11310
		[Token(Token = "0x4002C2E")]
		[FieldOffset(Offset = "0x38")]
		private BaseIsleEvents _isleEvents;
	}
}
