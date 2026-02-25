using System;
using System.Runtime.CompilerServices;
using DefaultNamespace;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Tutorial
{
	// Token: 0x02001182 RID: 4482
	[Token(Token = "0x2001182")]
	public class GameTutorialScenesManager : IGameManager, IBaseManager
	{
		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06006A68 RID: 27240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015CA")]
		public string Name
		{
			[Token(Token = "0x6006A68")]
			[Address(RVA = "0xB587", Offset = "0xB587", VA = "0xB587", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002AE RID: 686
		// (add) Token: 0x06006A69 RID: 27241 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A6A RID: 27242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002AE")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A69")]
			[Address(RVA = "0xB588", Offset = "0xB588", VA = "0xB588", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A6A")]
			[Address(RVA = "0xB589", Offset = "0xB589", VA = "0xB589", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002AF RID: 687
		// (add) Token: 0x06006A6B RID: 27243 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A6C RID: 27244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002AF")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A6B")]
			[Address(RVA = "0xB58A", Offset = "0xB58A", VA = "0xB58A", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A6C")]
			[Address(RVA = "0xB58B", Offset = "0xB58B", VA = "0xB58B", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A6D")]
		[Address(RVA = "0xB58C", Offset = "0xB58C", VA = "0xB58C")]
		public GameTutorialScenesManager(IGame game, Scenes[] scenes)
		{
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A6E")]
		[Address(RVA = "0xB58D", Offset = "0xB58D", VA = "0xB58D", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A6F")]
		[Address(RVA = "0xB58E", Offset = "0xB58E", VA = "0xB58E")]
		private void SceneManagerOnSceneLoadedEvent(string obj)
		{
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A70")]
		[Address(RVA = "0xB58F", Offset = "0xB58F", VA = "0xB58F", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A71")]
		[Address(RVA = "0xB590", Offset = "0xB590", VA = "0xB590")]
		private void ResolveLaunch()
		{
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A72")]
		[Address(RVA = "0xB591", Offset = "0xB591", VA = "0xB591")]
		private void Load(Scenes[] scenes)
		{
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A73")]
		[Address(RVA = "0xB592", Offset = "0xB592", VA = "0xB592")]
		private void Unload(Scenes[] scenes)
		{
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A74")]
		[Address(RVA = "0xB593", Offset = "0xB593", VA = "0xB593")]
		private void PopupControllerOnOnChangeStateEvent(int visibleFullscreenWndCount)
		{
		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A75")]
		[Address(RVA = "0xB594", Offset = "0xB594", VA = "0xB594")]
		private void SceneManagerOnSceneUnLoaded(string obj)
		{
		}

		// Token: 0x0400384D RID: 14413
		[Token(Token = "0x400384D")]
		[FieldOffset(Offset = "0x10")]
		private Scenes[] _scenes;

		// Token: 0x0400384E RID: 14414
		[Token(Token = "0x400384E")]
		[FieldOffset(Offset = "0x14")]
		private IGame _game;
	}
}
