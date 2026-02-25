using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.User;
using DefaultNamespace;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.Model.Data.Config;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Tutorial.Guide.Model
{
	// Token: 0x0200047B RID: 1147
	[Token(Token = "0x200047B")]
	public class GuideModel : AbstractModel
	{
		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x170004BE")]
		public bool Enabled
		{
			[Token(Token = "0x6001B2C")]
			[Address(RVA = "0x6CB6", Offset = "0x6CB6", VA = "0x6CB6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001B2D RID: 6957 RVA: 0x00005BC8 File Offset: 0x00003DC8
		// (set) Token: 0x06001B2E RID: 6958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BF")]
		public bool DevEditorToolEnabled
		{
			[Token(Token = "0x6001B2D")]
			[Address(RVA = "0x6CB7", Offset = "0x6CB7", VA = "0x6CB7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B2E")]
			[Address(RVA = "0x6CB8", Offset = "0x6CB8", VA = "0x6CB8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C0")]
		public RepeatedField<TutorialStepDic> StepsDicts
		{
			[Token(Token = "0x6001B2F")]
			[Address(RVA = "0x6CB9", Offset = "0x6CB9", VA = "0x6CB9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B30")]
			[Address(RVA = "0x6CBA", Offset = "0x6CBA", VA = "0x6CBA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C1")]
		public IGuideTarget CurrentTarget
		{
			[Token(Token = "0x6001B31")]
			[Address(RVA = "0x6CBB", Offset = "0x6CBB", VA = "0x6CBB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B32")]
			[Address(RVA = "0x6CBC", Offset = "0x6CBC", VA = "0x6CBC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C2")]
		public GuideConfig CurrentConfig
		{
			[Token(Token = "0x6001B33")]
			[Address(RVA = "0x6CBD", Offset = "0x6CBD", VA = "0x6CBD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B34")]
			[Address(RVA = "0x6CBE", Offset = "0x6CBE", VA = "0x6CBE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B36 RID: 6966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C3")]
		public IUserSettings UserSettings
		{
			[Token(Token = "0x6001B35")]
			[Address(RVA = "0x6CBF", Offset = "0x6CBF", VA = "0x6CBF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B36")]
			[Address(RVA = "0x6CC0", Offset = "0x6CC0", VA = "0x6CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x00005BE0 File Offset: 0x00003DE0
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C4")]
		public uint CurrentTutorialId
		{
			[Token(Token = "0x6001B37")]
			[Address(RVA = "0x6CC1", Offset = "0x6CC1", VA = "0x6CC1")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001B38")]
			[Address(RVA = "0x6CC2", Offset = "0x6CC2", VA = "0x6CC2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C5")]
		public GuideConfig PendingStep
		{
			[Token(Token = "0x6001B39")]
			[Address(RVA = "0x6CC3", Offset = "0x6CC3", VA = "0x6CC3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B3A")]
			[Address(RVA = "0x6CC4", Offset = "0x6CC4", VA = "0x6CC4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3B")]
		[Address(RVA = "0x6CC5", Offset = "0x6CC5", VA = "0x6CC5", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3C")]
		[Address(RVA = "0x6CC6", Offset = "0x6CC6", VA = "0x6CC6")]
		public GuideModel(UserData user, RepeatedField<TutorialStepDic> steps, bool systemEnabled, IUserSettings userSettings)
		{
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x6CC7", Offset = "0x6CC7", VA = "0x6CC7")]
		public bool TryGetGuideConfigs(string targetId, out IEnumerable<GuideConfig> configs)
		{
			return default(bool);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3E")]
		[Address(RVA = "0x6CC8", Offset = "0x6CC8", VA = "0x6CC8")]
		public void StartTutorial(uint tutorialId)
		{
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B3F")]
		[Address(RVA = "0x6CC9", Offset = "0x6CC9", VA = "0x6CC9")]
		public void FinishTutorial()
		{
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x6001B40")]
		[Address(RVA = "0x6CCA", Offset = "0x6CCA", VA = "0x6CCA")]
		public bool AddToWhiteList(uint tutorialId)
		{
			return default(bool);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x6001B41")]
		[Address(RVA = "0x6CCB", Offset = "0x6CCB", VA = "0x6CCB")]
		public bool TryMoveToNextStep(out GuideConfig config)
		{
			return default(bool);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x6001B42")]
		[Address(RVA = "0x6CCC", Offset = "0x6CCC", VA = "0x6CCC")]
		public bool TryCheckWhiteList(IEnumerable<IGuideTarget> targets, out GuideConfig config, out IGuideTarget target)
		{
			return default(bool);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x6CCD", Offset = "0x6CCD", VA = "0x6CCD")]
		public bool TryCheckTutorials(IEnumerable<IGuideTarget> targets, Predicate<GuideConfig> predicate, out GuideConfig config, out IGuideTarget target)
		{
			return default(bool);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B44")]
		[Address(RVA = "0x6CCE", Offset = "0x6CCE", VA = "0x6CCE")]
		public void PopulateTutorials()
		{
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x1CF9", Offset = "0x1CF9", VA = "0x1CF9")]
		[CompilerGenerated]
		private void <PopulateTutorials>g__AddTutorialEntry|49_0(GuideConfig config)
		{
		}

		// Token: 0x04000EB3 RID: 3763
		[Token(Token = "0x4000EB3")]
		[FieldOffset(Offset = "0xC")]
		public Scenes[] ScenesForUnload;

		// Token: 0x04000EB4 RID: 3764
		[Token(Token = "0x4000EB4")]
		[FieldOffset(Offset = "0x10")]
		public Scenes[] TargetScenes;

		// Token: 0x04000EB5 RID: 3765
		[Token(Token = "0x4000EB5")]
		[FieldOffset(Offset = "0x14")]
		public readonly bool SystemEnabled;

		// Token: 0x04000EB6 RID: 3766
		[Token(Token = "0x4000EB6")]
		[FieldOffset(Offset = "0x18")]
		public readonly HashSet<IGuideTarget> Targets;

		// Token: 0x04000EBE RID: 3774
		[Token(Token = "0x4000EBE")]
		[FieldOffset(Offset = "0x38")]
		private int _stepIndex;

		// Token: 0x04000EBF RID: 3775
		[Token(Token = "0x4000EBF")]
		[FieldOffset(Offset = "0x3C")]
		public readonly HashSet<uint> WhiteList;

		// Token: 0x04000EC0 RID: 3776
		[Token(Token = "0x4000EC0")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<uint> _completedTutorials;

		// Token: 0x04000EC1 RID: 3777
		[Token(Token = "0x4000EC1")]
		[FieldOffset(Offset = "0x44")]
		private readonly Dictionary<string, LinkedList<GuideConfig>> _guideConfigsCache;

		// Token: 0x04000EC2 RID: 3778
		[Token(Token = "0x4000EC2")]
		[FieldOffset(Offset = "0x48")]
		private readonly Dictionary<uint, List<GuideConfig>> _tutorials;

		// Token: 0x04000EC3 RID: 3779
		[Token(Token = "0x4000EC3")]
		[FieldOffset(Offset = "0x4C")]
		private Dictionary<uint, List<GuideConfig>> _onDemandTutorials;
	}
}
