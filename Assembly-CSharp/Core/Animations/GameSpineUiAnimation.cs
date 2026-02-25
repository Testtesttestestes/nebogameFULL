using System;
using System.Runtime.CompilerServices;
using Core.Materials;
using Il2CppDummyDll;
using Spine;
using Spine.Unity;
using UI;
using UnityEngine;

namespace Core.Animations
{
	// Token: 0x0200127D RID: 4733
	[Token(Token = "0x200127D")]
	[RequireComponent(typeof(SkeletonGraphic))]
	public class GameSpineUiAnimation : MonoBehaviour, IGameAnimation, IBoundsProvider, ISkeletonGraphicProvider, IGrayscalable, IAlpha
	{
		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06007077 RID: 28791 RVA: 0x00014700 File Offset: 0x00012900
		// (set) Token: 0x06007078 RID: 28792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F5")]
		public bool Loop
		{
			[Token(Token = "0x6007077")]
			[Address(RVA = "0xBABB", Offset = "0xBABB", VA = "0xBABB", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007078")]
			[Address(RVA = "0xBABC", Offset = "0xBABC", VA = "0xBABC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016F6 RID: 5878
		// (get) Token: 0x06007079 RID: 28793 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016F6")]
		public SkeletonGraphic SkeletonGraphic
		{
			[Token(Token = "0x6007079")]
			[Address(RVA = "0x1CBB", Offset = "0x1CBB", VA = "0x1CBB", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600707A")]
		[Address(RVA = "0xBABD", Offset = "0xBABD", VA = "0xBABD")]
		private void Awake()
		{
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600707B")]
		[Address(RVA = "0xBABE", Offset = "0xBABE", VA = "0xBABE")]
		private void OnDestroy()
		{
		}

		// Token: 0x170016F7 RID: 5879
		// (get) Token: 0x0600707C RID: 28796 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016F7")]
		public MonoBehaviour MonoBehaviour
		{
			[Token(Token = "0x600707C")]
			[Address(RVA = "0xBABF", Offset = "0xBABF", VA = "0xBABF", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000301 RID: 769
		// (add) Token: 0x0600707D RID: 28797 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600707E RID: 28798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000301")]
		public event Action<IGameAnimation> ClickEvent
		{
			[Token(Token = "0x600707D")]
			[Address(RVA = "0xBAC0", Offset = "0xBAC0", VA = "0xBAC0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600707E")]
			[Address(RVA = "0xBAC1", Offset = "0xBAC1", VA = "0xBAC1", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000302 RID: 770
		// (add) Token: 0x0600707F RID: 28799 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007080 RID: 28800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000302")]
		public event Action<IGameAnimation> CompleteEvent
		{
			[Token(Token = "0x600707F")]
			[Address(RVA = "0xBAC2", Offset = "0xBAC2", VA = "0xBAC2", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007080")]
			[Address(RVA = "0xBAC3", Offset = "0xBAC3", VA = "0xBAC3", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016F8 RID: 5880
		// (get) Token: 0x06007081 RID: 28801 RVA: 0x00014718 File Offset: 0x00012918
		// (set) Token: 0x06007082 RID: 28802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F8")]
		public int SortingLayerId
		{
			[Token(Token = "0x6007081")]
			[Address(RVA = "0xBAC4", Offset = "0xBAC4", VA = "0xBAC4", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007082")]
			[Address(RVA = "0xBAC5", Offset = "0xBAC5", VA = "0xBAC5", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x06007083 RID: 28803 RVA: 0x00014730 File Offset: 0x00012930
		// (set) Token: 0x06007084 RID: 28804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016F9")]
		public bool Interactable
		{
			[Token(Token = "0x6007083")]
			[Address(RVA = "0xBAC6", Offset = "0xBAC6", VA = "0xBAC6", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007084")]
			[Address(RVA = "0xBAC7", Offset = "0xBAC7", VA = "0xBAC7", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x06007085 RID: 28805 RVA: 0x00014748 File Offset: 0x00012948
		// (set) Token: 0x06007086 RID: 28806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016FA")]
		public int SortingOrder
		{
			[Token(Token = "0x6007085")]
			[Address(RVA = "0xBAC8", Offset = "0xBAC8", VA = "0xBAC8", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6007086")]
			[Address(RVA = "0xBAC9", Offset = "0xBAC9", VA = "0xBAC9", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06007087 RID: 28807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007087")]
		[Address(RVA = "0x1CBE", Offset = "0x1CBE", VA = "0x1CBE", Slot = "16")]
		public void Play(bool loop)
		{
		}

		// Token: 0x06007088 RID: 28808 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007088")]
		[Address(RVA = "0xBACA", Offset = "0xBACA", VA = "0xBACA")]
		private string GetFirstAnimationName()
		{
			return null;
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007089")]
		[Address(RVA = "0xBACB", Offset = "0xBACB", VA = "0xBACB")]
		private void AnimationStateOnComplete(TrackEntry trackEntry)
		{
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600708A")]
		[Address(RVA = "0xBACC", Offset = "0xBACC", VA = "0xBACC", Slot = "17")]
		public void Stop()
		{
		}

		// Token: 0x0600708B RID: 28811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600708B")]
		[Address(RVA = "0xBACD", Offset = "0xBACD", VA = "0xBACD", Slot = "19")]
		public void Pause()
		{
		}

		// Token: 0x0600708C RID: 28812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600708C")]
		[Address(RVA = "0x1CB7", Offset = "0x1CB7", VA = "0x1CB7", Slot = "18")]
		public void Play(string state, bool loop)
		{
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600708D")]
		[Address(RVA = "0xBACE", Offset = "0xBACE", VA = "0xBACE", Slot = "22")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x0600708E RID: 28814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600708E")]
		[Address(RVA = "0xBACF", Offset = "0xBACF", VA = "0xBACF", Slot = "23")]
		public void SetAlpha(float value)
		{
		}

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x0600708F RID: 28815 RVA: 0x00014760 File Offset: 0x00012960
		[Token(Token = "0x170016FB")]
		public Bounds Bounds
		{
			[Token(Token = "0x600708F")]
			[Address(RVA = "0xBAD0", Offset = "0xBAD0", VA = "0xBAD0", Slot = "20")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x06007090 RID: 28816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007090")]
		[Address(RVA = "0xBAD1", Offset = "0xBAD1", VA = "0xBAD1")]
		public GameSpineUiAnimation()
		{
		}

		// Token: 0x04003AAC RID: 15020
		[Token(Token = "0x4003AAC")]
		[FieldOffset(Offset = "0x10")]
		private SkeletonGraphic _skeletonGraphic;

		// Token: 0x04003AAD RID: 15021
		[Token(Token = "0x4003AAD")]
		[FieldOffset(Offset = "0x14")]
		private GrayscaleSpineUI _grayscale;

		// Token: 0x04003AAE RID: 15022
		[Token(Token = "0x4003AAE")]
		[FieldOffset(Offset = "0x18")]
		private AlphaSpineUI _alpha;
	}
}
