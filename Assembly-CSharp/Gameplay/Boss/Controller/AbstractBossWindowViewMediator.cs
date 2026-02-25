using System;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BA1 RID: 2977
	[Token(Token = "0x2000BA1")]
	public abstract class AbstractBossWindowViewMediator<V> : AbstractCozyViewMediator<BossInstanceModel, BossInstanceEvents, BossInstanceController, V> where V : Component
	{
		// Token: 0x060048C1 RID: 18625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048C1")]
		public AbstractBossWindowViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}
	}
}
