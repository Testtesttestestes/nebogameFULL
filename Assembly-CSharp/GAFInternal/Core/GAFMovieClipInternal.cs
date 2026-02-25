using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GAF.Assets;
using GAFInternal.Assets;
using GAFInternal.Data;
using GAFInternal.Objects;
using Il2CppDummyDll;
using UnityEngine;

namespace GAFInternal.Core
{
	// Token: 0x020013D8 RID: 5080
	[Token(Token = "0x20013D8")]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	public class GAFMovieClipInternal<ObjectsManagerType> : GAFBaseClip, IGAFMovieClip, IGAFBaseClip where ObjectsManagerType : GAFBaseObjectsManager
	{
		// Token: 0x06007929 RID: 31017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007929")]
		public void play()
		{
		}

		// Token: 0x0600792A RID: 31018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600792A")]
		public void pause()
		{
		}

		// Token: 0x0600792B RID: 31019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600792B")]
		public void stop()
		{
		}

		// Token: 0x0600792C RID: 31020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600792C")]
		public void gotoAndStop(uint _FrameNumber)
		{
		}

		// Token: 0x0600792D RID: 31021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600792D")]
		public void gotoAndPlay(uint _FrameNumber)
		{
		}

		// Token: 0x0600792E RID: 31022 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600792E")]
		public string sequenceIndexToName(uint _Index)
		{
			return null;
		}

		// Token: 0x0600792F RID: 31023 RVA: 0x000164A0 File Offset: 0x000146A0
		[Token(Token = "0x600792F")]
		public uint sequenceNameToIndex(string _Name)
		{
			return 0U;
		}

		// Token: 0x06007930 RID: 31024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007930")]
		public void setSequence(string _SequenceName, bool _PlayImmediately)
		{
		}

		// Token: 0x06007931 RID: 31025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007931")]
		public void setDefaultSequence(bool _PlayImmediately)
		{
		}

		// Token: 0x06007932 RID: 31026 RVA: 0x000164B8 File Offset: 0x000146B8
		[Token(Token = "0x6007932")]
		public uint getCurrentSequenceIndex()
		{
			return 0U;
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x000164D0 File Offset: 0x000146D0
		[Token(Token = "0x6007933")]
		[Obsolete("This method is obsolete. You can use property currentFrameNumber instead.")]
		public uint getCurrentFrameNumber()
		{
			return 0U;
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x000164E8 File Offset: 0x000146E8
		[Token(Token = "0x6007934")]
		public uint getFramesCount()
		{
			return 0U;
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x00016500 File Offset: 0x00014700
		[Token(Token = "0x6007935")]
		public GAFWrapMode getAnimationWrapMode()
		{
			return GAFWrapMode.Once;
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007936")]
		public void setAnimationWrapMode(GAFWrapMode _Mode)
		{
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x00016518 File Offset: 0x00014718
		[Token(Token = "0x6007937")]
		public bool isPlaying()
		{
			return default(bool);
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x00016530 File Offset: 0x00014730
		[Token(Token = "0x6007938")]
		public float duration()
		{
			return 0f;
		}

		// Token: 0x14000309 RID: 777
		// (add) Token: 0x06007939 RID: 31033 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600793A RID: 31034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000309")]
		public event Action<IGAFMovieClip> on_start_play
		{
			[Token(Token = "0x6007939")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600793A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400030A RID: 778
		// (add) Token: 0x0600793B RID: 31035 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600793C RID: 31036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400030A")]
		public event Action<IGAFMovieClip> on_stop_play
		{
			[Token(Token = "0x600793B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600793C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400030B RID: 779
		// (add) Token: 0x0600793D RID: 31037 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600793E RID: 31038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400030B")]
		public event Action<IGAFMovieClip> on_goto
		{
			[Token(Token = "0x600793D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600793E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400030C RID: 780
		// (add) Token: 0x0600793F RID: 31039 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007940 RID: 31040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400030C")]
		public event Action<IGAFMovieClip> on_sequence_change
		{
			[Token(Token = "0x600793F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400030D RID: 781
		// (add) Token: 0x06007941 RID: 31041 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007942 RID: 31042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400030D")]
		public event Action<IGAFMovieClip> on_clear
		{
			[Token(Token = "0x6007941")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007942")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06007943 RID: 31043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007943")]
		public override void initialize(GAFAnimationAssetInternal _Asset, int _TimelineID)
		{
		}

		// Token: 0x06007944 RID: 31044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007944")]
		public override void reload()
		{
		}

		// Token: 0x06007945 RID: 31045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007945")]
		public void cacheAllStates()
		{
		}

		// Token: 0x06007946 RID: 31046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007946")]
		protected virtual void setState(ref GAFObjectStateData _State, Dictionary<uint, IGAFObject> _Objects)
		{
		}

		// Token: 0x06007947 RID: 31047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007947")]
		public override IGAFObject getObject(uint _ID)
		{
			return null;
		}

		// Token: 0x06007948 RID: 31048 RVA: 0x00016548 File Offset: 0x00014748
		[Token(Token = "0x6007948")]
		public override int getObjectsCount()
		{
			return 0;
		}

		// Token: 0x06007949 RID: 31049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007949")]
		public override void clear(bool destroyChildren)
		{
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600794A")]
		public override void cleanView()
		{
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x0600794B RID: 31051 RVA: 0x00016560 File Offset: 0x00014760
		// (set) Token: 0x0600794C RID: 31052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017FF")]
		public uint currentSequenceIndex
		{
			[Token(Token = "0x600794B")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600794C")]
			protected set
			{
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x0600794D RID: 31053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001800")]
		public GAFSequenceData currentSequence
		{
			[Token(Token = "0x600794D")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600794E")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600794F")]
		private void Update()
		{
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007950")]
		protected override void Start()
		{
		}

		// Token: 0x06007951 RID: 31057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007951")]
		private void OnDestroy()
		{
		}

		// Token: 0x06007952 RID: 31058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007952")]
		private void OnApplicationFocus(bool _FocusStatus)
		{
		}

		// Token: 0x06007953 RID: 31059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007953")]
		private void OnApplicationPause(bool _PauseStatus)
		{
		}

		// Token: 0x06007954 RID: 31060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007954")]
		private void EditorUpdate()
		{
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007955")]
		private void OnUpdate(float _TimeDelta)
		{
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007956")]
		private void updateToFrame(uint _FrameNumber, bool _RefreshStates)
		{
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007957")]
		private void objManagerUpdateToFrame(uint _FrameNumber, bool _RefreshStates)
		{
		}

		// Token: 0x06007958 RID: 31064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007958")]
		private void setPlaying(bool _IsPlay)
		{
		}

		// Token: 0x06007959 RID: 31065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007959")]
		public override void onTransformChanged(GAFTransform.TransformType _Type)
		{
		}

		// Token: 0x0600795A RID: 31066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600795A")]
		public override void onGeometryChanged()
		{
		}

		// Token: 0x0600795B RID: 31067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600795B")]
		public override void onVisibilityChanged()
		{
		}

		// Token: 0x0600795C RID: 31068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600795C")]
		public override void onColorChanged()
		{
		}

		// Token: 0x0600795D RID: 31069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600795D")]
		public override void onMaskingChanged()
		{
		}

		// Token: 0x0600795E RID: 31070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600795E")]
		private void upgrade()
		{
		}

		// Token: 0x0600795F RID: 31071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600795F")]
		public GAFMovieClipInternal()
		{
		}

		// Token: 0x06007960 RID: 31072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007960")]
		private void removeTrigger(int _ID)
		{
		}

		// Token: 0x06007961 RID: 31073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007961")]
		private void removeAllTriggers(uint _FrameNumber)
		{
		}

		// Token: 0x06007962 RID: 31074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007962")]
		private void removeAllTriggers()
		{
		}

		// Token: 0x04003F46 RID: 16198
		[Token(Token = "0x4003F46")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private int m_ClipVersion;

		// Token: 0x04003F47 RID: 16199
		[Token(Token = "0x4003F47")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private int m_SequenceIndex;

		// Token: 0x04003F48 RID: 16200
		[Token(Token = "0x4003F48")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		private ObjectsManagerType m_ObjectsManager;

		// Token: 0x04003F49 RID: 16201
		[Token(Token = "0x4003F49")]
		[FieldOffset(Offset = "0x0")]
		private bool m_IsPlaying;

		// Token: 0x04003F4A RID: 16202
		[Token(Token = "0x4003F4A")]
		[FieldOffset(Offset = "0x0")]
		private bool m_ContiniousPlaying;

		// Token: 0x04003F4B RID: 16203
		[Token(Token = "0x4003F4B")]
		[FieldOffset(Offset = "0x0")]
		private bool m_IsFirstFrame;

		// Token: 0x04003F4C RID: 16204
		[Token(Token = "0x4003F4C")]
		[FieldOffset(Offset = "0x0")]
		private float m_Stopwatch;

		// Token: 0x04003F4D RID: 16205
		[Token(Token = "0x4003F4D")]
		[FieldOffset(Offset = "0x0")]
		private float m_StoredTime;

		// Token: 0x04003F4E RID: 16206
		[Token(Token = "0x4003F4E")]
		[FieldOffset(Offset = "0x0")]
		private float m_PreviouseUpdateTime;

		// Token: 0x04003F4F RID: 16207
		[Token(Token = "0x4003F4F")]
		[FieldOffset(Offset = "0x0")]
		private uint m_TargetFrame;

		// Token: 0x04003F55 RID: 16213
		[Token(Token = "0x4003F55")]
		[FieldOffset(Offset = "0x0")]
		public GAFAnimationAsset OkgFixAnimationAsset;

		// Token: 0x04003F56 RID: 16214
		[Token(Token = "0x4003F56")]
		[FieldOffset(Offset = "0x0")]
		public Material OkgFixMaterial;

		// Token: 0x04003F57 RID: 16215
		[Token(Token = "0x4003F57")]
		[FieldOffset(Offset = "0x0")]
		public Texture2D OkgFixTexture;

		// Token: 0x04003F58 RID: 16216
		[Token(Token = "0x4003F58")]
		[FieldOffset(Offset = "0x0")]
		public string OkgFixAnimationAssetName;
	}
}
