using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Utils.Cache;

namespace CloudsFly
{
	// Token: 0x02001300 RID: 4864
	[Token(Token = "0x2001300")]
	public class CloudsWorldObjectEngine : WorldObjectEngine<CloudWorldObjectEngineArgs>
	{
		// Token: 0x060073BD RID: 29629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073BD")]
		[Address(RVA = "0xBDA4", Offset = "0xBDA4", VA = "0xBDA4", Slot = "10")]
		protected override void OnInit(CloudWorldObjectEngineArgs args)
		{
		}

		// Token: 0x060073BE RID: 29630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073BE")]
		[Address(RVA = "0xBDA5", Offset = "0xBDA5", VA = "0xBDA5", Slot = "8")]
		protected override void OnLateUpdate()
		{
		}

		// Token: 0x060073BF RID: 29631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073BF")]
		[Address(RVA = "0xBDA6", Offset = "0xBDA6", VA = "0xBDA6", Slot = "9")]
		protected override void OnResetPositions(Vector3 deltaPos)
		{
		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C0")]
		[Address(RVA = "0xBDA7", Offset = "0xBDA7", VA = "0xBDA7")]
		private void CloudsCheck()
		{
		}

		// Token: 0x060073C1 RID: 29633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C1")]
		[Address(RVA = "0xBDA8", Offset = "0xBDA8", VA = "0xBDA8")]
		private void OnReleaseCloud(TiledCloudSpriteWorldObject tiledCloud)
		{
		}

		// Token: 0x060073C2 RID: 29634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C2")]
		[Address(RVA = "0xBDA9", Offset = "0xBDA9", VA = "0xBDA9")]
		private void SpawnClouds()
		{
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C3")]
		[Address(RVA = "0xBDAA", Offset = "0xBDAA", VA = "0xBDAA")]
		private void SpawnCloud(float position)
		{
		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60073C4")]
		[Address(RVA = "0xBDAB", Offset = "0xBDAB", VA = "0xBDAB")]
		private IEnumerator<float> GetPositions()
		{
			return null;
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C5")]
		[Address(RVA = "0xBDAC", Offset = "0xBDAC", VA = "0xBDAC")]
		private void AddUsedCloud(TiledCloudSpriteWorldObject tiledCloudSpriteControl)
		{
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073C6")]
		[Address(RVA = "0xBDAD", Offset = "0xBDAD", VA = "0xBDAD")]
		public CloudsWorldObjectEngine()
		{
		}

		// Token: 0x04003CA0 RID: 15520
		[Token(Token = "0x4003CA0")]
		[FieldOffset(Offset = "0x28")]
		private CloudWorldObjectEngineArgs _args;

		// Token: 0x04003CA1 RID: 15521
		[Token(Token = "0x4003CA1")]
		[FieldOffset(Offset = "0x2C")]
		private readonly List<TiledCloudSpriteWorldObject> usedTiledClouds;

		// Token: 0x04003CA2 RID: 15522
		[Token(Token = "0x4003CA2")]
		[FieldOffset(Offset = "0x30")]
		private GameObjectPool<TiledCloudSpriteWorldObject> tiledCloudsPool;

		// Token: 0x04003CA3 RID: 15523
		[Token(Token = "0x4003CA3")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 _lastCameraPosition;

		// Token: 0x04003CA4 RID: 15524
		[Token(Token = "0x4003CA4")]
		[FieldOffset(Offset = "0x40")]
		private int _lastIndex;
	}
}
