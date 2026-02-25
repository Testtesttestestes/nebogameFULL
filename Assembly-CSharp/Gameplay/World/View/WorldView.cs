using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CloudsFly;
using CloudsFly.Movement;
using Gameplay.Isles.Base;
using Gameplay.World.Controller;
using Gameplay.World.Model.View.IslandEngineActions;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.World.View
{
	// Token: 0x02000358 RID: 856
	[Token(Token = "0x2000358")]
	public class WorldView : MonoBehaviour
	{
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x00004B90 File Offset: 0x00002D90
		[Token(Token = "0x1700030D")]
		public WorldLevel CurrentWorldLevel
		{
			[Token(Token = "0x6001385")]
			[Address(RVA = "0x6575", Offset = "0x6575", VA = "0x6575")]
			get
			{
				return WorldLevel.Unknown;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x1700030E")]
		public bool AnyTweenHappened
		{
			[Token(Token = "0x6001386")]
			[Address(RVA = "0x6576", Offset = "0x6576", VA = "0x6576")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700030F")]
		public CloudObjectsEngineController CloudObjectsEngineController
		{
			[Token(Token = "0x6001387")]
			[Address(RVA = "0x6577", Offset = "0x6577", VA = "0x6577")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000107 RID: 263
		// (add) Token: 0x06001388 RID: 5000 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001389 RID: 5001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000107")]
		public event Action<WorldMovementTypes> MovStartEvent
		{
			[Token(Token = "0x6001388")]
			[Address(RVA = "0x6578", Offset = "0x6578", VA = "0x6578")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001389")]
			[Address(RVA = "0x6579", Offset = "0x6579", VA = "0x6579")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000108 RID: 264
		// (add) Token: 0x0600138A RID: 5002 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600138B RID: 5003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000108")]
		public event Action<WorldMovementTypes> MovCompleteEvent
		{
			[Token(Token = "0x600138A")]
			[Address(RVA = "0x657A", Offset = "0x657A", VA = "0x657A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600138B")]
			[Address(RVA = "0x657B", Offset = "0x657B", VA = "0x657B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000109 RID: 265
		// (add) Token: 0x0600138C RID: 5004 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600138D RID: 5005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000109")]
		public event Action<WorldLevel, WorldLevel> WorldLevelChangedEvent
		{
			[Token(Token = "0x600138C")]
			[Address(RVA = "0x657C", Offset = "0x657C", VA = "0x657C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600138D")]
			[Address(RVA = "0x657D", Offset = "0x657D", VA = "0x657D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600138E")]
		[Address(RVA = "0x657E", Offset = "0x657E", VA = "0x657E")]
		private void Awake()
		{
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600138F")]
		[Address(RVA = "0x657F", Offset = "0x657F", VA = "0x657F")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001390")]
		[Address(RVA = "0x6580", Offset = "0x6580", VA = "0x6580")]
		public void StopAnyMovement()
		{
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001391")]
		[Address(RVA = "0x6581", Offset = "0x6581", VA = "0x6581")]
		private void OnEngineInitialized()
		{
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001392")]
		[Address(RVA = "0x6582", Offset = "0x6582", VA = "0x6582")]
		private void OnChangeWindows(int visibleFullscreenWndCount)
		{
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001393")]
		[Address(RVA = "0x6583", Offset = "0x6583", VA = "0x6583")]
		private void CancelCurrentQueue()
		{
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001394")]
		[Address(RVA = "0x6584", Offset = "0x6584", VA = "0x6584")]
		public void MoveToLevel(WorldLevel targetLevel, bool immediate)
		{
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001395")]
		[Address(RVA = "0x6585", Offset = "0x6585", VA = "0x6585")]
		private void LevelChangedCallback(WorldLevel level)
		{
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001396")]
		[Address(RVA = "0x6586", Offset = "0x6586", VA = "0x6586")]
		private IIsleWorldObjectEngine GetIsleEngineByLevel(WorldLevel worldLevel)
		{
			return null;
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001397")]
		[Address(RVA = "0x6587", Offset = "0x6587", VA = "0x6587")]
		public void MoveToIsle(WorldLevel worldLevel, IIsle target, IIsle next1, IIsle next2, bool isHome, List<IIsle> validIsles)
		{
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001398")]
		[Address(RVA = "0x6588", Offset = "0x6588", VA = "0x6588")]
		public void Clear(WorldLevel worldLevel)
		{
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001399")]
		[Address(RVA = "0x6589", Offset = "0x6589", VA = "0x6589")]
		private void InvokeIslandEngineAction(BaseIsleEngineAction action)
		{
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139A")]
		[Address(RVA = "0x658A", Offset = "0x658A", VA = "0x658A")]
		private void HandleQueue()
		{
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139B")]
		[Address(RVA = "0x658B", Offset = "0x658B", VA = "0x658B")]
		private void ActionCompleteCallback(BaseIsleEngineAction action)
		{
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139C")]
		[Address(RVA = "0x658C", Offset = "0x658C", VA = "0x658C")]
		public WorldView()
		{
		}

		// Token: 0x04000A7B RID: 2683
		[Token(Token = "0x4000A7B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CloudObjectsEngineController _cloudObjectsEngineController;

		// Token: 0x04000A7C RID: 2684
		[Token(Token = "0x4000A7C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform[] _worldParts;

		// Token: 0x04000A7D RID: 2685
		[Token(Token = "0x4000A7D")]
		[FieldOffset(Offset = "0x18")]
		private WorldLevel _currentWorldLevel;

		// Token: 0x04000A7E RID: 2686
		[Token(Token = "0x4000A7E")]
		[FieldOffset(Offset = "0x0")]
		private static bool _anyTweenHappened;

		// Token: 0x04000A7F RID: 2687
		[Token(Token = "0x4000A7F")]
		[FieldOffset(Offset = "0x1C")]
		private UserIsleWorldObjectEngine _userIsleEngine;

		// Token: 0x04000A80 RID: 2688
		[Token(Token = "0x4000A80")]
		[FieldOffset(Offset = "0x20")]
		private ClanIsleWorldObjectEngine _clanIsleEngine;

		// Token: 0x04000A81 RID: 2689
		[Token(Token = "0x4000A81")]
		[FieldOffset(Offset = "0x24")]
		private AxisIsleWorldObjectEngine _axisIsleEngine;

		// Token: 0x04000A85 RID: 2693
		[Token(Token = "0x4000A85")]
		[FieldOffset(Offset = "0x34")]
		private WorldViewMediator _mediator;

		// Token: 0x04000A86 RID: 2694
		[Token(Token = "0x4000A86")]
		[FieldOffset(Offset = "0x38")]
		private readonly Queue<BaseIsleEngineAction> _actionsQueue;

		// Token: 0x04000A87 RID: 2695
		[Token(Token = "0x4000A87")]
		[FieldOffset(Offset = "0x3C")]
		private BaseIsleEngineAction _currentAction;
	}
}
