using System;
using System.Runtime.CompilerServices;
using CloudsFly.Movement;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001313 RID: 4883
	[Token(Token = "0x2001313")]
	[Serializable]
	public abstract class WorldObjectEngineArgs : MonoBehaviour
	{
		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06007407 RID: 29703 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007408 RID: 29704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001762")]
		public WorldMovementResolver WorldMovementResolver
		{
			[Token(Token = "0x6007407")]
			[Address(RVA = "0xBDD8", Offset = "0xBDD8", VA = "0xBDD8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6007408")]
			[Address(RVA = "0xBDD9", Offset = "0xBDD9", VA = "0xBDD9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06007409 RID: 29705
		[Token(Token = "0x6007409")]
		public abstract IWorldObjectEngine GetEngine();

		// Token: 0x0600740A RID: 29706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600740A")]
		[Address(RVA = "0xBDDA", Offset = "0xBDDA", VA = "0xBDDA")]
		protected WorldObjectEngineArgs()
		{
		}

		// Token: 0x04003CC3 RID: 15555
		[Token(Token = "0x4003CC3")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Camera camera;

		// Token: 0x04003CC4 RID: 15556
		[Token(Token = "0x4003CC4")]
		[FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public float cloudDistance;

		// Token: 0x04003CC5 RID: 15557
		[Token(Token = "0x4003CC5")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public int chunkSize;

		// Token: 0x04003CC6 RID: 15558
		[Token(Token = "0x4003CC6")]
		[FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public float widthCamera;

		// Token: 0x04003CC7 RID: 15559
		[Token(Token = "0x4003CC7")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Vector3 startCameraPosition;

		// Token: 0x04003CC8 RID: 15560
		[Token(Token = "0x4003CC8")]
		[FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Func<float, float, float, float> getRandomRange;

		// Token: 0x04003CC9 RID: 15561
		[Token(Token = "0x4003CC9")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public Func<float, float> getRandom;

		// Token: 0x04003CCA RID: 15562
		[Token(Token = "0x4003CCA")]
		[FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public Func<bool> getBlockResetPositions;

		// Token: 0x04003CCB RID: 15563
		[Token(Token = "0x4003CCB")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public Action<bool> setBlockResetPositions;

		// Token: 0x04003CCC RID: 15564
		[Token(Token = "0x4003CCC")]
		[FieldOffset(Offset = "0x3C")]
		[HideInInspector]
		public Action resetPositions;
	}
}
