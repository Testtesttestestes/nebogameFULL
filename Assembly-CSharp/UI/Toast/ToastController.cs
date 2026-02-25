using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using DG.Tweening;
using Gameplay.Aprs.View;
using Gameplay.Inventory.View;
using Gameplay.Medals.View;
using Gameplay.School.Model;
using Il2CppDummyDll;
using UI.Elements.Buildings;
using UnityEngine;
using Utils.Cache;

namespace UI.Toast
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	public class ToastController : MonoBehaviour
	{
		// Token: 0x06000A50 RID: 2640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x5DA3", Offset = "0x5DA3", VA = "0x5DA3")]
		private void Awake()
		{
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x5DA4", Offset = "0x5DA4", VA = "0x5DA4")]
		private void OnReleaseToast(ToastView pooledObject)
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x1B6D", Offset = "0x1B6D", VA = "0x1B6D")]
		public void Show(ToastTheme theme, string message)
		{
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x5DA5", Offset = "0x5DA5", VA = "0x5DA5")]
		public void Show(ToastController.ToastData toastData)
		{
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x5DA6", Offset = "0x5DA6", VA = "0x5DA6")]
		private bool TryShow(ToastController.ToastData data, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x5DA7", Offset = "0x5DA7", VA = "0x5DA7")]
		private void HandleQueue()
		{
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x5DA8", Offset = "0x5DA8", VA = "0x5DA8")]
		private float GetSpeedCoef()
		{
			return 0f;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x5DA9", Offset = "0x5DA9", VA = "0x5DA9")]
		private void ShiftQueue()
		{
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x5DAA", Offset = "0x5DAA", VA = "0x5DAA")]
		private void OnToastHideComplete(ToastView toastView)
		{
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x5DAB", Offset = "0x5DAB", VA = "0x5DAB")]
		private void OnShiftComplete()
		{
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x5DAC", Offset = "0x5DAC", VA = "0x5DAC")]
		public void StopAll()
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x5DAD", Offset = "0x5DAD", VA = "0x5DAD")]
		public ToastController()
		{
		}

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ToastView _toastViewPrefab;

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ToastController.ToastPrefabsStorage _toastPrefabs;

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float DefaultDuration;

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float ShiftDuration;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private uint _maxToastCount;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _elementSize;

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("При большом размере очереди ускоряем в coef раз скорость воспроизведений")]
		[SerializeField]
		private float _maxSpeedCoef;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Размер очереди при котором происходит максимальное ускорение")]
		[SerializeField]
		private int _maxSpeedQueueSize;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x34")]
		private GameObjectPool<ToastView> _toastPool;

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x38")]
		private Queue<ToastController.ToastData> _toastQueue;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x3C")]
		private List<ToastView> _currentToastView;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x40")]
		private Tween _updateQueueDelayedCall;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x44")]
		private Tween _shiftToastsDelayedCall;

		// Token: 0x02000172 RID: 370
		[Token(Token = "0x2000172")]
		public class ToastData : IDisposable
		{
			// Token: 0x17000152 RID: 338
			// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00003948 File Offset: 0x00001B48
			// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000152")]
			public ToastTheme Theme
			{
				[Token(Token = "0x6000A5C")]
				[Address(RVA = "0x5DAE", Offset = "0x5DAE", VA = "0x5DAE")]
				[CompilerGenerated]
				get
				{
					return ToastTheme.Unknown;
				}
				[Token(Token = "0x6000A5D")]
				[Address(RVA = "0x5DAF", Offset = "0x5DAF", VA = "0x5DAF")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000153")]
			public string Title
			{
				[Token(Token = "0x6000A5E")]
				[Address(RVA = "0x5DB0", Offset = "0x5DB0", VA = "0x5DB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A5F")]
				[Address(RVA = "0x5DB1", Offset = "0x5DB1", VA = "0x5DB1")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000154")]
			public string Message
			{
				[Token(Token = "0x6000A60")]
				[Address(RVA = "0x5DB2", Offset = "0x5DB2", VA = "0x5DB2")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A61")]
				[Address(RVA = "0x5DB3", Offset = "0x5DB3", VA = "0x5DB3")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000155")]
			public Transform Content
			{
				[Token(Token = "0x6000A62")]
				[Address(RVA = "0x5DB4", Offset = "0x5DB4", VA = "0x5DB4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A63")]
				[Address(RVA = "0x5DB5", Offset = "0x5DB5", VA = "0x5DB5")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000A64 RID: 2660 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x5DB6", Offset = "0x5DB6", VA = "0x5DB6")]
			private static string GetTitleByTheme(ToastTheme theme)
			{
				return null;
			}

			// Token: 0x06000A65 RID: 2661 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x5DB7", Offset = "0x5DB7", VA = "0x5DB7")]
			private static string GetUiResourceIdByTheme(ToastTheme theme)
			{
				return null;
			}

			// Token: 0x06000A66 RID: 2662 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x5DB8", Offset = "0x5DB8", VA = "0x5DB8")]
			public static ToastController.ToastData Create(ToastTheme theme, string message, ArtifactData artifactData)
			{
				return null;
			}

			// Token: 0x06000A67 RID: 2663 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x5DB9", Offset = "0x5DB9", VA = "0x5DB9")]
			public static ToastController.ToastData Create(ToastTheme theme, string message, MedalDicWrapper medal)
			{
				return null;
			}

			// Token: 0x06000A68 RID: 2664 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x5DBA", Offset = "0x5DBA", VA = "0x5DBA")]
			public static ToastController.ToastData Create(ToastTheme theme, string message, AprDicWrapper apr)
			{
				return null;
			}

			// Token: 0x06000A69 RID: 2665 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x5DBB", Offset = "0x5DBB", VA = "0x5DBB")]
			public static ToastController.ToastData Create(ToastTheme theme, string message, SchoolSpellData schoolSpellData)
			{
				return null;
			}

			// Token: 0x06000A6A RID: 2666 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x5DBC", Offset = "0x5DBC", VA = "0x5DBC")]
			public static ToastController.ToastData Create(ToastTheme theme, string message)
			{
				return null;
			}

			// Token: 0x06000A6B RID: 2667 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x5DBD", Offset = "0x5DBD", VA = "0x5DBD", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06000A6C RID: 2668 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x5DBE", Offset = "0x5DBE", VA = "0x5DBE")]
			public ToastData()
			{
			}
		}

		// Token: 0x02000173 RID: 371
		[Token(Token = "0x2000173")]
		[Serializable]
		public class ToastPrefabsStorage
		{
			// Token: 0x17000156 RID: 342
			// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000156")]
			public MedalView MedalViewPrefab
			{
				[Token(Token = "0x6000A6D")]
				[Address(RVA = "0x5DBF", Offset = "0x5DBF", VA = "0x5DBF")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000157")]
			public ArtifactView ArtifactViewPrefab
			{
				[Token(Token = "0x6000A6E")]
				[Address(RVA = "0x5DC0", Offset = "0x5DC0", VA = "0x5DC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000158")]
			public GameRawImage GameRawImagePrefab
			{
				[Token(Token = "0x6000A6F")]
				[Address(RVA = "0x5DC1", Offset = "0x5DC1", VA = "0x5DC1")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000159")]
			public AprViewSmall AprViewSmallPrefab
			{
				[Token(Token = "0x6000A70")]
				[Address(RVA = "0x5DC2", Offset = "0x5DC2", VA = "0x5DC2")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700015A")]
			public SpellItem SpellItemPrefab
			{
				[Token(Token = "0x6000A71")]
				[Address(RVA = "0x5DC3", Offset = "0x5DC3", VA = "0x5DC3")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000A72 RID: 2674 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x5DC4", Offset = "0x5DC4", VA = "0x5DC4")]
			public ToastPrefabsStorage()
			{
			}

			// Token: 0x04000477 RID: 1143
			[Token(Token = "0x4000477")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private ArtifactView _artifactViewPrefab;

			// Token: 0x04000478 RID: 1144
			[Token(Token = "0x4000478")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private MedalView _medalViewPrefab;

			// Token: 0x04000479 RID: 1145
			[Token(Token = "0x4000479")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameRawImage _gameRawImagePrefab;

			// Token: 0x0400047A RID: 1146
			[Token(Token = "0x400047A")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private AprViewSmall _aprViewSmallPrefab;

			// Token: 0x0400047B RID: 1147
			[Token(Token = "0x400047B")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private SpellItem _spellItemPrefab;
		}
	}
}
