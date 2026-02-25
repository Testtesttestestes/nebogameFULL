using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace DefaultNamespace
{
	// Token: 0x02000E4A RID: 3658
	[Token(Token = "0x2000E4A")]
	public class SceneAppManager
	{
		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x060059A3 RID: 22947 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001244")]
		public static SceneAppManager Instance
		{
			[Token(Token = "0x60059A3")]
			[Address(RVA = "0x4445", Offset = "0x4445", VA = "0x4445")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400021A RID: 538
		// (add) Token: 0x060059A4 RID: 22948 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060059A5 RID: 22949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400021A")]
		public event Action<string> SceneLoadedEvent
		{
			[Token(Token = "0x60059A4")]
			[Address(RVA = "0xA6CF", Offset = "0xA6CF", VA = "0xA6CF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60059A5")]
			[Address(RVA = "0xA6D0", Offset = "0xA6D0", VA = "0xA6D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400021B RID: 539
		// (add) Token: 0x060059A6 RID: 22950 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060059A7 RID: 22951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400021B")]
		public event Action<string> SceneUnloadedEvent
		{
			[Token(Token = "0x60059A6")]
			[Address(RVA = "0xA6D1", Offset = "0xA6D1", VA = "0xA6D1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60059A7")]
			[Address(RVA = "0xA6D2", Offset = "0xA6D2", VA = "0xA6D2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x060059A8 RID: 22952 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001245")]
		public List<Scenes> CurrentScenes
		{
			[Token(Token = "0x60059A8")]
			[Address(RVA = "0xA6D3", Offset = "0xA6D3", VA = "0xA6D3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x060059A9 RID: 22953 RVA: 0x0000FE70 File Offset: 0x0000E070
		// (set) Token: 0x060059AA RID: 22954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001246")]
		public bool EnableLoad
		{
			[Token(Token = "0x60059A9")]
			[Address(RVA = "0xA6D4", Offset = "0xA6D4", VA = "0xA6D4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60059AA")]
			[Address(RVA = "0xA6D5", Offset = "0xA6D5", VA = "0xA6D5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059AB")]
		[Address(RVA = "0xA6D6", Offset = "0xA6D6", VA = "0xA6D6")]
		private SceneAppManager()
		{
		}

		// Token: 0x060059AC RID: 22956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059AC")]
		[Address(RVA = "0xA6D7", Offset = "0xA6D7", VA = "0xA6D7")]
		private void CompleteLoad([NotNull] SceneAppManager.SceneRequestData request)
		{
		}

		// Token: 0x060059AD RID: 22957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059AD")]
		[Address(RVA = "0xA6D8", Offset = "0xA6D8", VA = "0xA6D8")]
		private void CompleteUnload([NotNull] SceneAppManager.SceneRequestData request)
		{
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059AE")]
		[Address(RVA = "0xA6D9", Offset = "0xA6D9", VA = "0xA6D9")]
		private void LoadScene(SceneAppManager.SceneRequestData value)
		{
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60059AF")]
		[Address(RVA = "0xA6DA", Offset = "0xA6DA", VA = "0xA6DA")]
		private IEnumerator LoadSceneRoutine(SceneAppManager.SceneRequestData request)
		{
			return null;
		}

		// Token: 0x060059B0 RID: 22960 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60059B0")]
		[Address(RVA = "0xA6DB", Offset = "0xA6DB", VA = "0xA6DB")]
		private IEnumerator UnloadSceneRoutine(SceneAppManager.SceneRequestData request)
		{
			return null;
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B1")]
		[Address(RVA = "0xA6DC", Offset = "0xA6DC", VA = "0xA6DC")]
		private void HandleQueue()
		{
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B2")]
		[Address(RVA = "0xA6DD", Offset = "0xA6DD", VA = "0xA6DD")]
		private void HandleRequest(SceneAppManager.SceneRequestData request)
		{
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B3")]
		[Address(RVA = "0xA6DE", Offset = "0xA6DE", VA = "0xA6DE")]
		private void AddScene(Scenes scene)
		{
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B4")]
		[Address(RVA = "0xA6DF", Offset = "0xA6DF", VA = "0xA6DF")]
		private void RemoveScene(Scenes scene)
		{
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x0000FE88 File Offset: 0x0000E088
		[Token(Token = "0x60059B5")]
		public bool TryGetSceneArgs<T>(Scenes scene, out SceneAppManager.SceneArgs<T> sceneArgs)
		{
			return default(bool);
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B6")]
		[Address(RVA = "0xA6E0", Offset = "0xA6E0", VA = "0xA6E0")]
		public void LoadScene(params Scenes[] scenes)
		{
		}

		// Token: 0x060059B7 RID: 22967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B7")]
		[Address(RVA = "0xA6E1", Offset = "0xA6E1", VA = "0xA6E1")]
		public void LoadScene(Scenes scene)
		{
		}

		// Token: 0x060059B8 RID: 22968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B8")]
		public void LoadScene<TArgs>(SceneAppManager.SceneArgs<TArgs> sceneWhitArgs)
		{
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059B9")]
		[Address(RVA = "0xA6E2", Offset = "0xA6E2", VA = "0xA6E2")]
		public void UnloadScene(Scenes scene)
		{
		}

		// Token: 0x060059BA RID: 22970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059BA")]
		[Address(RVA = "0xA6E3", Offset = "0xA6E3", VA = "0xA6E3")]
		public void UnloadScene(params Scenes[] scenes)
		{
		}

		// Token: 0x04003072 RID: 12402
		[Token(Token = "0x4003072")]
		[FieldOffset(Offset = "0x0")]
		private static SceneAppManager _instance;

		// Token: 0x04003076 RID: 12406
		[Token(Token = "0x4003076")]
		[FieldOffset(Offset = "0x14")]
		private SceneAppManager.SceneRequestData _currentRequest;

		// Token: 0x04003077 RID: 12407
		[Token(Token = "0x4003077")]
		[FieldOffset(Offset = "0x18")]
		private readonly Queue<SceneAppManager.SceneRequestData> _requestQueue;

		// Token: 0x04003078 RID: 12408
		[Token(Token = "0x4003078")]
		[FieldOffset(Offset = "0x1C")]
		private readonly Dictionary<Scenes, SceneAppManager.SceneArgs> _sceneArgs;

		// Token: 0x02000E4B RID: 3659
		[Token(Token = "0x2000E4B")]
		public class SceneArgs
		{
			// Token: 0x060059BB RID: 22971 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60059BB")]
			[Address(RVA = "0xA6E4", Offset = "0xA6E4", VA = "0xA6E4")]
			protected SceneArgs(Scenes scene)
			{
			}

			// Token: 0x0400307A RID: 12410
			[Token(Token = "0x400307A")]
			[FieldOffset(Offset = "0x8")]
			public readonly Scenes Scene;
		}

		// Token: 0x02000E4C RID: 3660
		[Token(Token = "0x2000E4C")]
		public class SceneArgs<T> : SceneAppManager.SceneArgs
		{
			// Token: 0x060059BC RID: 22972 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60059BC")]
			public SceneArgs(Scenes scene, [NotNull] T data)
			{
			}

			// Token: 0x0400307B RID: 12411
			[Token(Token = "0x400307B")]
			[FieldOffset(Offset = "0x0")]
			[NotNull]
			public readonly T Data;
		}

		// Token: 0x02000E4D RID: 3661
		[Token(Token = "0x2000E4D")]
		private class SceneRequestData : IDisposable
		{
			// Token: 0x060059BD RID: 22973 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60059BD")]
			[Address(RVA = "0xA6E5", Offset = "0xA6E5", VA = "0xA6E5")]
			public SceneRequestData(Scenes scene, SceneAppManager.SceneRequestData.RequestType type)
			{
			}

			// Token: 0x060059BE RID: 22974 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60059BE")]
			[Address(RVA = "0xA6E6", Offset = "0xA6E6", VA = "0xA6E6")]
			public SceneRequestData(Scenes scene, SceneAppManager.SceneRequestData.RequestType type, SceneAppManager.SceneArgs sceneArgs)
			{
			}

			// Token: 0x060059BF RID: 22975 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60059BF")]
			[Address(RVA = "0xA6E7", Offset = "0xA6E7", VA = "0xA6E7")]
			public string GetSceneName()
			{
				return null;
			}

			// Token: 0x060059C0 RID: 22976 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
			[Token(Token = "0x60059C0")]
			[Address(RVA = "0xA6E8", Offset = "0xA6E8", VA = "0xA6E8")]
			public bool TryGetSceneArgs(out SceneAppManager.SceneArgs value)
			{
				return default(bool);
			}

			// Token: 0x060059C1 RID: 22977 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60059C1")]
			[Address(RVA = "0xA6E9", Offset = "0xA6E9", VA = "0xA6E9", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0400307C RID: 12412
			[Token(Token = "0x400307C")]
			[FieldOffset(Offset = "0x8")]
			public readonly Scenes Scene;

			// Token: 0x0400307D RID: 12413
			[Token(Token = "0x400307D")]
			[FieldOffset(Offset = "0xC")]
			public readonly SceneAppManager.SceneRequestData.RequestType Type;

			// Token: 0x0400307E RID: 12414
			[Token(Token = "0x400307E")]
			[FieldOffset(Offset = "0x10")]
			private string _sceneName;

			// Token: 0x0400307F RID: 12415
			[Token(Token = "0x400307F")]
			[FieldOffset(Offset = "0x14")]
			private SceneAppManager.SceneArgs _sceneArgs;

			// Token: 0x02000E4E RID: 3662
			[Token(Token = "0x2000E4E")]
			public enum RequestType
			{
				// Token: 0x04003081 RID: 12417
				[Token(Token = "0x4003081")]
				AsyncLoad = 1,
				// Token: 0x04003082 RID: 12418
				[Token(Token = "0x4003082")]
				AsyncUnload
			}
		}
	}
}
