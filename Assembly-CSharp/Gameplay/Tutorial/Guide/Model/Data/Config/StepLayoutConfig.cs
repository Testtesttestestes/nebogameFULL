using System;
using System.Runtime.CompilerServices;
using Gameplay.TutorialV2.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.Model.Data.Config
{
	// Token: 0x02000488 RID: 1160
	[Token(Token = "0x2000488")]
	[Serializable]
	public class StepLayoutConfig
	{
		// Token: 0x14000133 RID: 307
		// (add) Token: 0x06001B72 RID: 7026 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001B73 RID: 7027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000133")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6001B72")]
			[Address(RVA = "0x6CF1", Offset = "0x6CF1", VA = "0x6CF1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001B73")]
			[Address(RVA = "0x6CF2", Offset = "0x6CF2", VA = "0x6CF2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x6CF3", Offset = "0x6CF3", VA = "0x6CF3")]
		public void OnChanged()
		{
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x6CF4", Offset = "0x6CF4", VA = "0x6CF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x6CF5", Offset = "0x6CF5", VA = "0x6CF5")]
		public StepLayoutConfig Clone()
		{
			return null;
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x6CF6", Offset = "0x6CF6", VA = "0x6CF6")]
		public StepLayoutConfig()
		{
		}

		// Token: 0x04000ED9 RID: 3801
		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x8")]
		public int Revision;

		// Token: 0x04000EDB RID: 3803
		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0x10")]
		public uint AprId;

		// Token: 0x04000EDC RID: 3804
		[Token(Token = "0x4000EDC")]
		[FieldOffset(Offset = "0x14")]
		public AprLayout AprLayout;

		// Token: 0x04000EDD RID: 3805
		[Token(Token = "0x4000EDD")]
		[FieldOffset(Offset = "0x18")]
		public MessageBubbleView.MessageBubbleViewArgs BubbleMessageArgs;

		// Token: 0x04000EDE RID: 3806
		[Token(Token = "0x4000EDE")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float BlockY;

		// Token: 0x04000EDF RID: 3807
		[Token(Token = "0x4000EDF")]
		[FieldOffset(Offset = "0x20")]
		[Range(-0.5f, 0.5f)]
		public float BlockX;

		// Token: 0x04000EE0 RID: 3808
		[Token(Token = "0x4000EE0")]
		[FieldOffset(Offset = "0x24")]
		public TargetPointerConfig TargetPointer;

		// Token: 0x04000EE1 RID: 3809
		[Token(Token = "0x4000EE1")]
		[FieldOffset(Offset = "0x28")]
		public GraphicPointerConfig GraphicPointerConfig;
	}
}
