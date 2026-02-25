using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Consts;
using UnityEngine;

namespace UI.Rewards
{
	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	public class RewardsRender : AbstractRewardsRender
	{
		// Token: 0x140000E2 RID: 226
		// (add) Token: 0x06000B54 RID: 2900 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B55 RID: 2901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E2")]
		public event Action OnDropProcessCompleteEvent
		{
			[Token(Token = "0x6000B54")]
			[Address(RVA = "0x5E72", Offset = "0x5E72", VA = "0x5E72")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B55")]
			[Address(RVA = "0x5E73", Offset = "0x5E73", VA = "0x5E73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x5E74", Offset = "0x5E74", VA = "0x5E74")]
		private void Start()
		{
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x5E75", Offset = "0x5E75", VA = "0x5E75")]
		private void OnValidate()
		{
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x5E76", Offset = "0x5E76", VA = "0x5E76")]
		protected List<List<RewardData>> GetIconValueRewardsLines(List<RewardData> iconValueTypes, RewardsRender.IconValueRewardInLine[] iconValueRewardTypesByLines)
		{
			return null;
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x5E77", Offset = "0x5E77", VA = "0x5E77")]
		protected List<RewardData> GetRewardByFitTypes(RewardData[] rewards, RewardTypes[] fitTypes)
		{
			return null;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x5E78", Offset = "0x5E78", VA = "0x5E78")]
		private bool TryGetSeparator(RewardData reward, out RewardsRender.ContainerSeparatorConfig config)
		{
			return default(bool);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x5E79", Offset = "0x5E79", VA = "0x5E79")]
		private bool TryGetSupportedRewardConfig(RewardData reward, out RewardsRender.RewardRenderConfigRecord config)
		{
			return default(bool);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x5E7A", Offset = "0x5E7A", VA = "0x5E7A")]
		private void SetPreloadEnabled(bool value)
		{
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x5E7B", Offset = "0x5E7B", VA = "0x5E7B")]
		public void DispatchDropProcessCompleteEvent()
		{
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x6000B5E")]
		public bool TryGetRender<T>(RewardTypes rewardType, out T renderer) where T : AbstractRewardRender
		{
			return default(bool);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x5E7C", Offset = "0x5E7C", VA = "0x5E7C", Slot = "6")]
		public override void Render()
		{
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x5E7D", Offset = "0x5E7D", VA = "0x5E7D")]
		public void Test()
		{
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x5E7E", Offset = "0x5E7E", VA = "0x5E7E")]
		public void TestRemoveAll()
		{
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x5E7F", Offset = "0x5E7F", VA = "0x5E7F")]
		public RewardsRender()
		{
		}

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RewardTypes[] _iconValueRewardTypes;

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardTypes[] _artikulArtifactRewardTypes;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RewardsRender.IconValueRewardInLine[] _iconValueRewardTypesByLines;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private RewardsRender.ContainerSeparatorConfig[] _artContainerSeparators;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RewardsRender.RewardRenderConfigRecord[] _supportedRewards;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RewardsContainer _containerPrefab;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _preloader;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _preloadEnabled;

		// Token: 0x02000198 RID: 408
		[Token(Token = "0x2000198")]
		[Serializable]
		public class RewardRenderConfigRecord
		{
			// Token: 0x06000B63 RID: 2915 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B63")]
			[Address(RVA = "0x1F6A", Offset = "0x1F6A", VA = "0x1F6A")]
			public AbstractRewardRender InstantiateExecuter(Transform parent, RewardsRender rootRender)
			{
				return null;
			}

			// Token: 0x06000B64 RID: 2916 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x5E80", Offset = "0x5E80", VA = "0x5E80")]
			public RewardRenderConfigRecord()
			{
			}

			// Token: 0x0400052C RID: 1324
			[Token(Token = "0x400052C")]
			[FieldOffset(Offset = "0x8")]
			public RewardTypes[] FitRewardTypes;

			// Token: 0x0400052D RID: 1325
			[Token(Token = "0x400052D")]
			[FieldOffset(Offset = "0xC")]
			public AbstractRewardRender ExecuteScriptPrefab;
		}

		// Token: 0x02000199 RID: 409
		[Token(Token = "0x2000199")]
		[Serializable]
		public class IconValueRewardInLine
		{
			// Token: 0x06000B65 RID: 2917 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x5E81", Offset = "0x5E81", VA = "0x5E81")]
			public IconValueRewardInLine()
			{
			}

			// Token: 0x0400052E RID: 1326
			[Token(Token = "0x400052E")]
			[FieldOffset(Offset = "0x8")]
			public RewardTypes[] RewardTypes;
		}

		// Token: 0x0200019A RID: 410
		[Token(Token = "0x200019A")]
		[Serializable]
		public class ContainerSeparatorConfig
		{
			// Token: 0x06000B66 RID: 2918 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x5E82", Offset = "0x5E82", VA = "0x5E82")]
			public ContainerSeparatorConfig()
			{
			}

			// Token: 0x0400052F RID: 1327
			[Token(Token = "0x400052F")]
			[FieldOffset(Offset = "0x8")]
			public RewardTypes[] RewardTypes;

			// Token: 0x04000530 RID: 1328
			[Token(Token = "0x4000530")]
			[FieldOffset(Offset = "0xC")]
			public GameObject Prefab;
		}
	}
}
