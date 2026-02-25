using System;
using System.Runtime.CompilerServices;
using Core.Rounting;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path.Factories
{
	// Token: 0x020011EC RID: 4588
	[Token(Token = "0x20011EC")]
	public class PathNodeFactory<T> : IPathNodeFactory where T : AbstractPathNode, new()
	{
		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06006CF6 RID: 27894 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700162E")]
		public string Name
		{
			[Token(Token = "0x6006CF6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06006CF7 RID: 27895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF7")]
		public PathNodeFactory([NotNull] string name)
		{
		}

		// Token: 0x06006CF8 RID: 27896 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006CF8")]
		public AbstractPathNode Create(string name, IGame game, OpTokenRepository tokenRepository)
		{
			return null;
		}
	}
}
