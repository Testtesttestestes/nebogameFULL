using System;
using System.Runtime.CompilerServices;
using Gameplay.Isles.Base.View;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012EC RID: 4844
	[Token(Token = "0x20012EC")]
	public class BaseIsleWorldObject : WorldObject<IsleCloudObjectArgs>
	{
		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x0600734C RID: 29516 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700174B")]
		public IsleBossContainer BossContainer
		{
			[Token(Token = "0x600734C")]
			[Address(RVA = "0xBD55", Offset = "0xBD55", VA = "0xBD55")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x0600734D RID: 29517 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700174C")]
		public Renderer ReferenceRenderer
		{
			[Token(Token = "0x600734D")]
			[Address(RVA = "0xBD56", Offset = "0xBD56", VA = "0xBD56")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x0600734E RID: 29518 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700174D")]
		public Transform CameraAnchor
		{
			[Token(Token = "0x600734E")]
			[Address(RVA = "0xBD57", Offset = "0xBD57", VA = "0xBD57")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600734F RID: 29519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600734F")]
		[Address(RVA = "0xBD58", Offset = "0xBD58", VA = "0xBD58")]
		private void Awake()
		{
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06007350 RID: 29520 RVA: 0x00014BB0 File Offset: 0x00012DB0
		// (set) Token: 0x06007351 RID: 29521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700174E")]
		public ulong Id
		{
			[Token(Token = "0x6007350")]
			[Address(RVA = "0xBD59", Offset = "0xBD59", VA = "0xBD59")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6007351")]
			[Address(RVA = "0xBD5A", Offset = "0xBD5A", VA = "0xBD5A")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06007352 RID: 29522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007352")]
		[Address(RVA = "0xBD5B", Offset = "0xBD5B", VA = "0xBD5B", Slot = "11")]
		protected override void OnInit(IsleCloudObjectArgs args)
		{
		}

		// Token: 0x06007353 RID: 29523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007353")]
		[Address(RVA = "0xBD5C", Offset = "0xBD5C", VA = "0xBD5C", Slot = "12")]
		protected virtual void HandleDataChanged()
		{
		}

		// Token: 0x06007354 RID: 29524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007354")]
		[Address(RVA = "0xBD5D", Offset = "0xBD5D", VA = "0xBD5D")]
		private void OnDestroy()
		{
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007355")]
		[Address(RVA = "0xBD5E", Offset = "0xBD5E", VA = "0xBD5E", Slot = "13")]
		public virtual void UpdateOrder()
		{
		}

		// Token: 0x06007356 RID: 29526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007356")]
		[Address(RVA = "0xBD5F", Offset = "0xBD5F", VA = "0xBD5F", Slot = "14")]
		public virtual void Reset()
		{
		}

		// Token: 0x06007357 RID: 29527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007357")]
		[Address(RVA = "0xBD60", Offset = "0xBD60", VA = "0xBD60")]
		public BaseIsleWorldObject()
		{
		}

		// Token: 0x04003C59 RID: 15449
		[Token(Token = "0x4003C59")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Renderer _referenceRenderer;

		// Token: 0x04003C5A RID: 15450
		[Token(Token = "0x4003C5A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Transform _cameraAnchor;

		// Token: 0x04003C5B RID: 15451
		[Token(Token = "0x4003C5B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private IsleBossContainer _bossContainer;

		// Token: 0x04003C5D RID: 15453
		[Token(Token = "0x4003C5D")]
		[FieldOffset(Offset = "0x40")]
		private IsleCloudObjectArgs _previousArgs;
	}
}
