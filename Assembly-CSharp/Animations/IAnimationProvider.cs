using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Animations
{
	// Token: 0x0200132A RID: 4906
	[Token(Token = "0x200132A")]
	public interface IAnimationProvider
	{
		// Token: 0x0600744C RID: 29772
		[Token(Token = "0x600744C")]
		bool TryStartAnimation(Transform target, out float duration);
	}
}
