using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.Model.Data
{
	// Token: 0x02000485 RID: 1157
	[Token(Token = "0x2000485")]
	public interface IGuideTarget
	{
		// Token: 0x14000132 RID: 306
		// (add) Token: 0x06001B68 RID: 7016
		// (remove) Token: 0x06001B69 RID: 7017
		[Token(Token = "0x14000132")]
		event Action<IGuideTarget> ResolveEvent;

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001B6A RID: 7018
		[Token(Token = "0x170004CE")]
		string Id { [Token(Token = "0x6001B6A")] get; }

		// Token: 0x06001B6B RID: 7019
		[Token(Token = "0x6001B6B")]
		Rect GetRect(Camera camera);

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001B6C RID: 7020
		[Token(Token = "0x170004CF")]
		MonoBehaviour MonoBehaviour { [Token(Token = "0x6001B6C")] get; }

		// Token: 0x06001B6D RID: 7021
		[Token(Token = "0x6001B6D")]
		bool CheckParams(params long[] values);

		// Token: 0x06001B6E RID: 7022
		[Token(Token = "0x6001B6E")]
		bool TryGetOverrides<T>(out T component);
	}
}
